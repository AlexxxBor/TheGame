using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitcher : MonoBehaviour
{
    void Update()
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
