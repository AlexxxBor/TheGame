using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    [Header("Constraints")]
    [SerializeField] private bool _useConstraints = false;
    [SerializeField] private float _leftConstraint;
    [SerializeField] private float _rightConstraint;
    
    private Vector3 _moveDirection;

    public Vector3 MoveDirection
    {
        get
        {
            return _moveDirection;
        }

        set
        {
            _moveDirection = value;
        }
    }

    private void Update()
    {
        transform.position += _moveDirection * (_moveSpeed * Time.deltaTime);

        if (_useConstraints)
        {
            float constraintedX = Mathf.Clamp(transform.position.x, _leftConstraint, _rightConstraint);
            transform.position = new Vector3(constraintedX, transform.position.y, transform.position.z);
        }
    }
}
