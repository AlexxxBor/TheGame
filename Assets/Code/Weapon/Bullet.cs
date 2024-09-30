﻿using Assets.Controllers;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Weapon
{
    [RequireComponent(typeof(Rigidbody))]

    internal class Bullet : MonoBehaviour
    {
        [SerializeField] float _force;
        [SerializeField] float _lifeTime = 7.0f;

        [SerializeField] private BulletProjectorData[] _bulletHoles; //
        private BulletProjectorHelper _projectorHelper; //


        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        private Rigidbody _rigidbody;
        private bool _isActive;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _projectorHelper = new BulletProjectorHelper(_bulletHoles);
        }

        private void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);

            if (other.collider.TryGetComponent(out HealthController healthController))
            {
                if (healthController.CanTakeDamage(1))
                {
                    _projectorHelper.CreateBulletHole(other.contacts[0].point, other.contacts[0].normal, other.transform); //

                    return;
                }

                Rigidbody rigidbody = other.collider.gameObject.GetOrAddComponent<Rigidbody>();
                rigidbody.AddForce(_rigidbody.velocity * _force, ForceMode.Impulse);
            }
        }

        internal void Run(Vector3 path, Vector3 startPosition)
        {
            transform.position = startPosition;

            transform.SetParent(null);
            gameObject.SetActive(true);

            _rigidbody.WakeUp();
            _rigidbody.AddForce(path, ForceMode.Impulse);

            _isActive = true;
            StartCoroutine(Die());
        }
        public void Sleep()
        {
            _rigidbody.Sleep();
            gameObject.SetActive(false);
            _isActive = false;
        }

        private IEnumerator Die()
        {
            while(_lifeTime >= 0.0f)
            {
                _lifeTime -= 1.0f;
                yield return new WaitForSeconds(1.0f);
            }

            Destroy(gameObject);
        }
    }
}