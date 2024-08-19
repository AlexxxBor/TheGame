using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Character Character;
    public float OffsetFrom = 0.5f;
    public float OffsetBetween = 1.0f;
    public Transform SpawnPoint;

    private void Start()
    {
        (float x, float y, float z) spawnPoint = (SpawnPoint.position.x, SpawnPoint.position.y, SpawnPoint.position.z);

        for (int i = 0; i < 4; i++)
        {
            Character instantiate = Instantiate(Character, new Vector3((spawnPoint.x + i * OffsetBetween) + OffsetFrom, spawnPoint.y, spawnPoint.z), Quaternion.identity);
            Debug.LogWarning($"Character with name {instantiate.name} created");
        }
    }
}
