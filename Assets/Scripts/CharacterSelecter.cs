using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelecter : MonoBehaviour
{
    public List<GameObject> ShipPrefabs;

    public int SelectedCharacter1;
    public int SelectedCharacter2;

    public TMP_Dropdown Player1;
    public TMP_Dropdown Player2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Player1.value);
        SelectedCharacter1 = Player1.value;
        SelectedCharacter2 = Player2.value;
    }
}
