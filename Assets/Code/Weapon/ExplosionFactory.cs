using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ExplosionFactory : MonoBehaviour
{
    public Explosion Create()
    {
        return new GameObject().AddComponent<Explosion>();
    }
}
