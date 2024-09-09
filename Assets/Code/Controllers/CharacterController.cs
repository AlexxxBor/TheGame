using UnityEngine;

[RequireComponent(typeof(MoveComponent))]
[RequireComponent(typeof(RotationComponent))]
[RequireComponent(typeof(HealthComponent))]

public class CharacterController : MonoBehaviour
{
    [SerializeField] private MoveComponent _moveComponent;
    [SerializeField] private RotationComponent _rotationComponent;
    [SerializeField] private HealthComponent _healthComponent;

    private void Awake()
    {
        _moveComponent = GetComponent<MoveComponent>();
        _rotationComponent = GetComponent<RotationComponent>();
        _healthComponent = GetComponent<HealthComponent>();
    }

    private void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xDirection, 0, zDirection);

        _moveComponent.MoveDirection = direction;
        _rotationComponent.RotationDirection = _moveComponent.MoveDirection;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<FirstAidKit>(out FirstAidKit kit))
        {
            if (_healthComponent.Health < _healthComponent.MaxHealth)
            {
                Destroy(kit.transform.gameObject);
                _healthComponent.Health += kit.Hp;
                
            }
        }
    }
}
