using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitcher : MonoBehaviour
{
    private Character[] _allCharacters;
    private void Start()
    {
        _allCharacters = FindObjectsByType<Character>(FindObjectsInactive.Include, FindObjectsSortMode.None);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _allCharacters.Length > 0)
        {
            foreach (Character character in _allCharacters)
            {
                character.gameObject.SetActive(!character.gameObject.activeSelf);
            }
        }
    }
}
