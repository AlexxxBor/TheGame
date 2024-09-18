using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [Header("Bricks")]
    [SerializeField] private GameObject _brickPrefab;
    [SerializeField] private int _rowCount;
    [SerializeField] private int _columnCount;
    [SerializeField] private float _offsetHorizontal;
    [SerializeField] private float _offsetVertical;

    [Header("Materials")]
    [SerializeField] private List<Material> _materials = new List<Material>();

    private void Start()
    {
        int materrialId = 0;
        GameObject brick;

        for (int i = 0; i < _rowCount; i++)
        {
            if (materrialId == _materials.Count)
            {
                materrialId = 0;
            }

            for (int j = 0; j < _columnCount; j++)
            {
                float newX = transform.position.x + (j * _offsetHorizontal);
                float newY = transform.position.y + (i * _offsetVertical);

                Vector3 newPosition = new Vector3(newX, newY, 0);
                brick = Instantiate(_brickPrefab, newPosition, Quaternion.identity);
                brick.transform.SetParent(transform);
                brick.GetComponent<Renderer>().material = _materials[materrialId];
            }

            materrialId++;
        }
    }
}
