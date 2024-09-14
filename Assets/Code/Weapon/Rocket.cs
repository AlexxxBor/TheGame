using Assets.Controllers;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Weapon
{
    [RequireComponent(typeof(Rigidbody))]

    public class Rocket : MonoBehaviour
    {
        [SerializeField] private float _powerExplosion;
        [SerializeField] private float _scale;
        [SerializeField] public GameObject _explosionEffectPrefab;

        private Rigidbody _rigidBody;
        private Collider[] _collidedObjects;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _collidedObjects = new Collider[128];
        }

        private void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);
            Instantiate(_explosionEffectPrefab, transform);

            float radius = _scale / 2;
            Vector3 center = other.contacts[0].point;

            int countofCollisions = Physics.OverlapSphereNonAlloc(center, radius, _collidedObjects);
            Debug.DrawLine(center, new Vector3(0, radius, 0), Color.red);

            for (int i = 0; i < countofCollisions; i++)
            {
                Collider collidedObject = _collidedObjects[i];

                if (collidedObject.TryGetComponent(out HealthController healthController))
                {
                    if (healthController.CanTakeDamage(healthController.MaxHp))
                    {
                        return;
                    }

                    if (healthController.TryGetComponent(out Rigidbody rigidBody) == false)
                    {
                        rigidBody = healthController.AddComponent<Rigidbody>();
                    }

                    rigidBody.AddExplosionForce(_powerExplosion, center, radius);
                }
            }
        }

        internal void Run(Vector3 path)
        {
            transform.SetParent(null);
            _rigidBody.WakeUp();
            _rigidBody.isKinematic = false;
            _rigidBody.AddForce(path, ForceMode.Impulse);
        }

        internal void Sleep(Vector3 startPoint)
        {
            _rigidBody.Sleep();
            _rigidBody.isKinematic = true;
            transform.position = startPoint;
        }
    }
}
