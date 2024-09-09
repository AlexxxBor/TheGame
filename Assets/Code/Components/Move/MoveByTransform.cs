using UnityEngine;

public class MoveByTransform : MoveComponent
{
    public float MoveSpeed = 10f;

    void Update()
    {
        transform.position += MoveDirection * (MoveSpeed * Time.deltaTime);
    }
}
