using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int _health;

    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            if (value < 0)
            {
                _health = 0;
                return;
            }

            _health = value;
        }
    }
}
