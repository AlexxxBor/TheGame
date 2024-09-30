using UnityEngine;

namespace Weapon
{
    public static class RigidBodyHelper
    {
        public static Rigidbody GetOrAddRigidbody(this GameObject gameObject)
        {
            if (gameObject.TryGetComponent(out Rigidbody rigidbody) == false)
            {
                rigidbody = gameObject.AddComponent<Rigidbody>();
            }

            return rigidbody;
        }
    }
}
