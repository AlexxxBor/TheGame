using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveComponent))]
[RequireComponent (typeof(BallComponent))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MoveComponent _moveComponent;
    [SerializeField] private BallComponent _ballComponent;

    private void Awake()
    {
        _moveComponent = GetComponent<MoveComponent>();
        _ballComponent = GetComponent<BallComponent>();
    }

    private void Update()
    {
        float directionX = Input.GetAxis("Horizontal");
        Vector3 currentDirection = new Vector3(directionX, 0, 0);
        _moveComponent.MoveDirection = currentDirection;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ballComponent.Throw();
        }
    }
}
