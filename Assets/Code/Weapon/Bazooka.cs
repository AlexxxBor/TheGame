using UnityEngine;

namespace Weapon
{
    public sealed class Bazooka : Weapon
    {
        [SerializeField] private Rocket _rocketBrefab;
        private Rocket _initiateRocket;

        protected override void Start()
        {
            base.Start();
        }

        public override void Fire()
        {
            if (_initiateRocket)
            {
                _initiateRocket.Run(_barrel.forward * Force);
                _initiateRocket = null;
            }
        }

        public override void Recharge()
        {
            if (_initiateRocket != null)
            {
                return;
            }

            _initiateRocket = Instantiate(_rocketBrefab, _barrel);
            _initiateRocket.Sleep(_barrel.position);
        }
    }
}