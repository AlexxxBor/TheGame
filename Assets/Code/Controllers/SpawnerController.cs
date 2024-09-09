using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _spawn;

    private void Start()
    {
        if(_spawnPoints.Length == 0 && _spawn == null)
        {
            return;
        }

        System.Random rnd = new System.Random();

        foreach (Transform poin in _spawnPoints)
        {
            Destroy(poin.gameObject);
            Instantiate(_spawn, poin.position, Quaternion.identity, transform);
        }
    }
}
