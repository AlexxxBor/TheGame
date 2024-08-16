using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public Character Character;
    public float OffsetBelow = 0.5f;
    public float OffsetBetween = 0.1f;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Character instantiate = Instantiate(Character, new Vector3(2, i + i * OffsetBetween + OffsetBelow, -2), Quaternion.identity);
            Debug.LogWarning($"Character with name {instantiate.name} created");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Character[] allCharacters = FindObjectsByType<Character>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            
            foreach (Character character in allCharacters)
            {
                character.gameObject.SetActive(!character.gameObject.activeSelf);
            }
        }
    }
}
