using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Code
{
    internal class Damage : MonoBehaviour
    {
        public int BaseDamage = 10;
        public float Multiplier = 1.0f;

        private void Start()
        {
            Debug.LogWarning($"Нанесённый урон: {CalculateDamage(BaseDamage, Multiplier)}");
        }

        private float CalculateDamage(int damage, float multiplier) => damage * multiplier;
    }

}
