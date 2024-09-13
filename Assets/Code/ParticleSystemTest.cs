using UnityEngine;

namespace Assets.Code
{
    internal class ParticleSystemTest : MonoBehaviour
    {
        [SerializeField] private GameObject _explosionEffect;
        [SerializeField] private bool _activate = false;

        private GameObject _effectCopy;
        private ParticleSystem _particles;

        private void Awake()
        {
            _effectCopy = Instantiate(_explosionEffect, transform);
            _effectCopy.transform.SetParent(null);

            _particles = _effectCopy.GetComponent<ParticleSystem>();
        }

        private void OnValidate()
        {
            if (_activate)
            {
                _particles.Play();
            }
        }
    }
}
