using UnityEngine;

public class CornerFactorDeviation : MonoBehaviour
{
    [SerializeField] private float _deviationFactor;

    public float Deviation {
        get
        {
            return _deviationFactor;
        }
    } 
}
