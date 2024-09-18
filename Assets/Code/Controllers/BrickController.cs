using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(HealthComponent))]
public class BrickController : MonoBehaviour
{
    [SerializeField] private HealthComponent _healthComponent;

    private void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }

    private void Update()
    {
        if (_healthComponent.Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
