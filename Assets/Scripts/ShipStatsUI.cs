using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipStatsUI : MonoBehaviour
{
    public Text CoinsCollectedText;
    public Text VelocityStats;
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
