using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerTranslate : MonoBehaviour
{
    public float Speed = 5f;

    void Update()
    {
        float xDirection = 0;
        float zDirection = 0;

        xDirection = Input.GetAxis("Horizontal");
        zDirection = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3 (xDirection, 0,  zDirection) * (Speed * Time.deltaTime);
        transform.Translate (direction);
    }
}
