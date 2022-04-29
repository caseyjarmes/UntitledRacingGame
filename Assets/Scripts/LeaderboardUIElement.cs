using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LeaderboardUIElement : MonoBehaviour
{
    public TMP_Text PositionText;
    public TMP_Text DriverNameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void SetPositionText(string position)
    {
        PositionText.text = position.ToString();
    }
    public void SetName(string ShipName)
    {
        DriverNameText.text = ShipName;
    }
    //Add more elements
}
