using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool IsDead;
    public bool IsEnemy;
    public int Hp;

    private void Start()
    {
        Material material = GetComponent<MeshRenderer>().material;

        if (IsEnemy)
        {
            material.color = Color.red;
        }
        else
        {
            material.color = Color.blue;
        }
    }

    private void Update()
    {
        if (Hp < 0)
        {
            Hp = 0;
        }

        IsDead = Hp == 0 ? true : false;
    }
}
