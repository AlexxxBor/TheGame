using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    [SerializeField] private int _hpFrom = 1;
    [SerializeField] private int _hpTo = 3;

    public int Hp { get; private set; }

    private void Awake()
    {
        if (_hpFrom == _hpTo)
        {
            Hp = _hpFrom;
            return;
        }

        Hp = Random.Range(_hpFrom, _hpTo + 1);
    }
}
