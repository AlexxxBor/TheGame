using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private MoveComponent _moveComponent;
    [SerializeField] private RotationComponent _rotationComponent;

    private void Awake()
    {
        _moveComponent = GetComponent<MoveComponent>();
        _rotationComponent = GetComponent<RotationComponent>();
    }

    private void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xDirection, 0, zDirection);

        _moveComponent.MoveDirection = direction;
        _rotationComponent.RotationDirection = _moveComponent.MoveDirection;
    }
}
