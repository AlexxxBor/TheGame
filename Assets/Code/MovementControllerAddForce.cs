using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerAddForce : MonoBehaviour
{
    public float Force = 5f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xDirection = 0;
        float zDirection = 0;

        xDirection = Input.GetAxis("Horizontal");
        zDirection = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xDirection, 0, zDirection) * Force;
        _rigidbody.AddForce(direction);
    }
}
