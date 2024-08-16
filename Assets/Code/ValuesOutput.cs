using UnityEngine;

namespace Assets.Code
{
    internal class ValuesOutput : MonoBehaviour
    {
        public int Integer;
        public float Float;
        public bool Boolean;

        private void OnValidate()
        {
            Debug.Log($"Целочисленное значение теперь: {Integer}");
            Debug.Log($"Новое число с плавающей точкой: {Float}");
            Debug.Log($"Булево значение равно: {Boolean}");
        }
    }
}
