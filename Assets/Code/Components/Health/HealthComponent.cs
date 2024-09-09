using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 20;
    [SerializeField] private int _health = 10;

    public int Health
    {
        get
        {
            return _health;
        }
        
        set
        {
            _health = value >= _maxHealth ? _maxHealth : value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return _maxHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        if(_health - damage < 0)
        {
            _health = 0;
            return;
        }

        _health -= damage;
    }

    public void RestoreHitPoints(int value)
    {
        _health = Mathf.Clamp(_health + value, 0, _maxHealth);
    }
}
