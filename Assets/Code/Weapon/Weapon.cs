using UnityEngine;

namespace Assets.Code.Weapon
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private float _shotDelay;

        public float LastShootTime { get; protected set; }
        protected bool CanShoot { get; private set; }
        
        protected float Force
        {
            get
            {
                return _force;
            }
        }

        private void Update()
        {
            CanShoot = _shotDelay <= LastShootTime;

            if (CanShoot)
            {
                return;
            }

            LastShootTime += Time.deltaTime;
        }

        public abstract void Fire();

        public abstract void Recharge();
    }
}
