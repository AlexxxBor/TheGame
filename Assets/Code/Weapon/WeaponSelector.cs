using System;

namespace Weapon
{
    public sealed class WeaponSelector
    {
        private int _currentWeaponIndex;
        private Weapon _currentWeapon;

        private readonly Weapon[] _weapons;

        public WeaponSelector(Weapon[] weapons)
        {
            _weapons = weapons;
        }

        internal void Fire()
        {
            if (_currentWeapon != null)
            {
                _currentWeapon.Fire();
            }
        }

        internal void Recharge()
        {
            if (_currentWeapon != null)
            {
                _currentWeapon.Recharge();
            }
        }

        internal void Next()
        {
            _currentWeaponIndex++;
            SelectWeapon();
        }

        internal void Prev()
        {
            _currentWeaponIndex++;
            SelectWeapon();
        }

        private void SelectWeapon()
        {
            if (_currentWeapon != null)
            {
                _currentWeapon.SetActive(false);
            }

            int index = Math.Abs(_currentWeaponIndex % _weapons.Length);
            _currentWeapon = _weapons[index];

            _currentWeapon.SetActive(true);
        }
    }
}
