using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private int _damage;
    
    private Rigidbody _body;
    private GameObject _platform;

    public GameObject Platform
    {
        set
        {
            _platform = value;
        }
        
    }

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<HealthComponent>(out HealthComponent brickHealth))
        {
            brickHealth.Health -= _damage;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            _body.velocity = Vector3.zero;
            transform.position = _platform.transform.position;
            transform.SetParent(_platform.transform);
        }
    }
}
