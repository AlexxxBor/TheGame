using UnityEngine;

public class RotationComponent : MonoBehaviour
{
    public float RotationSpeed = 5f;
    public Vector3 RotationDirection;

    private float _deltaAngle;
    private Quaternion _currentRotation;
    private Quaternion _targetRotation;
    private Quaternion _newRotation;

    void Update()
    {
        if (RotationDirection == Vector3.zero)
        {
            return;
        }

        _deltaAngle = RotationSpeed * Time.deltaTime;

        _currentRotation = transform.rotation;
        _targetRotation = Quaternion.LookRotation(RotationDirection);
        _newRotation = Quaternion.RotateTowards(_currentRotation, _targetRotation, _deltaAngle);

        transform.rotation = _newRotation;
    }
}
