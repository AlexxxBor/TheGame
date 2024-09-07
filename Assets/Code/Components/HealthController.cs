using UnityEngine;

namespace Assets.Code.Components
{
    internal class HealthController : MonoBehaviour
    {
        [SerializeField] private int _health;

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
                _isAlive = false;
                return false;
            }

            return true;
        }
        
    }
}
