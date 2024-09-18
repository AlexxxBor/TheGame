using System.Collections.Generic;
using UnityEngine;

namespace Weapon
{
    public sealed class Rifle : Weapon
    {
        [SerializeField] private int _countInClip;
        [SerializeField] private Bullet _bulletPrefab;

        private Transform _bulletRoot;
        private readonly Queue<Bullet> _bullets;

        private void Start()
        {
            _bulletRoot = new GameObject("BulletRoot").transform;
            Recharge();
        }

        public override void Fire()
        {
            if (CanShoot == false)
            {
                return;
            }

            if (TryGetBullet(out Bullet bullet))
            {
                bullet.Run(_barrel.forward * Force, _barrel.position);
                LastShootTime = 0.0f;
            }
        }

        public override void Recharge()
        {
            _bullets = new Bullet[_countInClip];

            for (int i = 0; i < _countInClip; i++)
            {
                Bullet bullet = Instantiate(_bulletPrefab, _bulletRoot);
                bullet.Sleep();

                _bullets[i] = bullet;
            }
        }
    }
}
