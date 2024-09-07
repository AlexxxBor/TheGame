using System.Collections;
using UnityEngine;

namespace Assets.Code.Components
{
    internal class HealthController : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private int _liveTime;

        private bool _isAlive = true;

        public bool CanTakeDamage(int damage)
        {
            if (_isAlive == false)
            {
                return false;
            }

            _health -= damage;

            if (_health <= 0)
            {
                StartCoroutine(Die());

                _isAlive = false;
                return false;
            }

            return true;
        }

        private IEnumerator Die()
        {
            while (_liveTime >= 0)
            {
                _liveTime -= 1;
                yield return new WaitForSeconds(1.0f);
            }

            StartCoroutine(Fade());
        }

        public IEnumerator Fade()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                Color color = renderer.material.color;

                for (float alpha = 1.0f; alpha >= 0; alpha -= 0.1f)
                {
                    
                    color.a = alpha;
                    Debug.Log(color.a);
                    renderer.material.color = color;
                    yield return new WaitForSeconds(0.1f);
                }
            }

            Destroy(gameObject);
        }

    }
}
