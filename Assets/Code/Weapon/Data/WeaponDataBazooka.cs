using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = nameof(WeaponDataBazooka), menuName = "Data/Weapon/DataBazooka")]
    public sealed class WeaponDataBazooka : WeaponData
    {
        [SerializeField] private float _rocketBangForce;

        public float RocketBangForce
        {
            get
            { 
                return _rocketBangForce;
            }
        }
    }
}
