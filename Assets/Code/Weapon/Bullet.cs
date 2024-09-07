using UnityEngine;

namespace Assets.Code.Weapon
{
    [RequireComponent(typeof(Rigidbody))]

    internal class Bullet : MonoBehaviour
    {
        private Rigidbody _rigidBody;
        private bool _isActive;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
        }

        private void OnBecameInvisible()
        {
            if(_isActive == false)
            {
                return;
            }

            Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);
        }

        internal void Run(Vector3 path, Vector3 startPosition)
        {
            transform.position = startPosition;

            gameObject.SetActive(true);
            _rigidBody.WakeUp();
            _rigidBody.AddForce(path, ForceMode.Impulse);

            _isActive = true;
        }
        public void Sleep()
        {
            _rigidBody.Sleep();
            gameObject.SetActive(false);
            _isActive = false;
        }
    }
}