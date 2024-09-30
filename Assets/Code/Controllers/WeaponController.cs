using UnityEngine;

namespace Weapon
{
    public class WeaponController : MonoBehaviour
    {
        private WeaponSelector _weaponSelector;

        private void Start()
        {
            Weapon[] weapons = gameObject.GetComponentsInChildren<Weapon>(true);
            _weaponSelector = new WeaponSelector(weapons);
        }

        private void Update()
        {
            float scrollWheel = Input.GetAxis("Mouse ScrollWheel");

            if (scrollWheel >= 0.1f)
            {
                _weaponSelector.Next();
            }

            if (scrollWheel <= -0.1f)
            {
                _weaponSelector.Prev();
            }

            if (Input.GetMouseButton(0))
            {
                _weaponSelector.Fire();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                _weaponSelector.Recharge();
            }
        }
    }
}

