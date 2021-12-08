using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipStatsUI : MonoBehaviour
{
    public TextMeshProUGUI CoinsCollectedText;
    public TextMeshProUGUI VelocityStats;
    public CarControl CarControl;
    public int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CarControl.CoinsCollected != coins)
        {
            CoinsCollectedText.text = $"Crystals Collected: {CarControl.CoinsCollected.ToString()}";
            coins++;
        }
        VelocityStats.text = $"Speed: {CarControl.ReturnVehicleVelocity()} Mph";
    }
}
