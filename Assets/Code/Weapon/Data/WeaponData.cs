using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = nameof(WeaponData), menuName = "Data/Weapon/Data")]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] private float _force;
        [SerializeField] private float _shotDelay;

        public float Force
        {
            get
            {
                return _force;
            } 
        }

        public float ShotDelay
        {
            get
            {
                return _shotDelay;
            }
        }
    }
}
