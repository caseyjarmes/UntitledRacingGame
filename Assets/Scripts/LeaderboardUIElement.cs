using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LeaderboardUIElement : MonoBehaviour
{
    public TMP_Text PositionText;
    public TMP_Text DriverNameText;
    public TMP_Text CrystalCountText;
    public TMP_Text BestTimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public void SetPositionText(string position)
    {
        PositionText.text = position;
    }
    public void SetName(string ShipName)
    {
        DriverNameText.text = ShipName;
    }
    public void SetCrystalCollected(string CrystalCount)
    {
        CrystalCountText.text = CrystalCount;
    }
    public void SetBestTime(float BestTime)
    {
        BestTimeText.text = $"{(int)BestTime / 60}:{(BestTime) % 60:00.000}";
    }
    //Add more elements
}
