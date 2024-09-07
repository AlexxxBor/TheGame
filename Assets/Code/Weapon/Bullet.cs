using Assets.Code.Components;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Code.Weapon
{
    [RequireComponent(typeof(Rigidbody))]

    internal class Bullet : MonoBehaviour
    {
        [SerializeField] float _force;

        private Rigidbody _rigidbody;
        private bool _isActive;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
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

            if (other.collider.TryGetComponent(out HealthController healthController))
            {
                if (healthController.CanTakeDamage(1))
                {
                    return;
                }

                if (other.collider.TryGetComponent(out Rigidbody rigidbody) == false)
                {
                    rigidbody = other.collider.AddComponent<Rigidbody>();
                }

                rigidbody.AddForce(_rigidbody.velocity * _force, ForceMode.Impulse);
            }
        }

        internal void Run(Vector3 path, Vector3 startPosition)
        {
            transform.position = startPosition;

            gameObject.SetActive(true);
            _rigidbody.WakeUp();
            _rigidbody.AddForce(path, ForceMode.Impulse);

            _isActive = true;
        }
        public void Sleep()
        {
            _rigidbody.Sleep();
            gameObject.SetActive(false);
            _isActive = false;
        }
    }
}