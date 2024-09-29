using System;
using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = nameof(WeaponUpgradeData), menuName = "Data/Weapon/Upgrade")]
    public sealed class WeaponUpgradeData : ScriptableObject
    {
        [Serializable]
        private class WeaponDataByLevel
        {
            public int Level;
            public WeaponData Data;
        }

        [SerializeField] private WeaponDataByLevel[] _weaponData;
        [SerializeField] private WeaponData _weaponDataDefault;

        public WeaponData WeaponDataDefault
        {
            get
            {
                return _weaponDataDefault;
            }
        }

        internal bool TryGetWeaponData(int level, out WeaponData weaponData)
        {
            for (int i = 0; i < _weaponData.Length; i++)
            {
                WeaponDataByLevel data = _weaponData[i];

                if(data.Level == level)
                {
                    weaponData = data.Data;
                    return true;
                }
            }

            weaponData = default;
            return false;
        }
    }
}
