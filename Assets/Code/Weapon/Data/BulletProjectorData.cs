using UnityEngine;

namespace Weapon
{
    [CreateAssetMenu(fileName = nameof(BulletProjectorData), menuName = "Data/Weapon/BulletProjectorData")]
    internal sealed class BulletProjectorData : ScriptableObject
    {
        [SerializeField] private Material _material;
        [SerializeField] private float _lightRange = 0.4f;
        [SerializeField] private float _lightIntensity = 5.0f;
        [SerializeField] private float _lightInnerSpotAngle = 7.0f;
        [SerializeField] private float _lightSpotAngle = 30.0f;

        public Material Material { get => _material; }
        public float LightRange { get => _lightRange; }
        public float LightIntensity { get => _lightIntensity; }
        public float LightInnerSpotAngle { get => _lightInnerSpotAngle; }
        public float LightSpotAngle { get => _lightSpotAngle; }
    }
}
