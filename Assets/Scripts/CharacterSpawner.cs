using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Character Character;
    public int Count = 4;
    public Transform SpawnPoint;
    public float OffsetFrom = 0.5f;
    public float OffsetBetween = 1.0f;
    

    private void Start()
    {
        (float x, float y, float z) spawnPoint = (SpawnPoint.position.x, SpawnPoint.position.y, SpawnPoint.position.z);

        for (int i = 0; i < Count; i++)
        {
            Character instantiate = Instantiate(Character, new Vector3((spawnPoint.x + i * OffsetBetween) + OffsetFrom, spawnPoint.y, spawnPoint.z), Quaternion.identity);
        }
    }
}
