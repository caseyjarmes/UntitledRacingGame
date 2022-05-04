using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuFlavorTextManager : MonoBehaviour
{

    public TMP_Dropdown neutralShipDD;
    public Text neutralShipText;

    public TMP_Dropdown trackDD;
    public Text trackText;

    public GameObject modeSelectPanel;
    public GameObject openingNarration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (neutralShipDD.value == 0)
        {
            neutralShipText.text = "A balanced personal vehicle used by the Karkarians for planetary missions. Smells like fish and gasoline. Driven by Karkaro. Neutral Stats";
        }
        else if (neutralShipDD.value == 1)
        {
            neutralShipText.text = "An experimental ultra-fast racing ship that struggles with tight corners. Incredibly stylish. Driven by F.C. Skawax. +Speed, -Weight, -- Handling";
        }
        if (neutralShipDD.value == 2)
        {
            neutralShipText.text = "The hovership piloted by Bonny Skawax prior to her disappearance. Holds the most SPEEDWAY records for a single hovership. Driven by F.C. Skawax. +Speed, -Handling";
        }
        else if (neutralShipDD.value == 3)
        {
            neutralShipText.text = "A fast and heavy ship designed to smash through other racers. Its canons have thankfully been deactivated for the race. Driven by Calypso Wyght. +Speed, +Weight";
        }
        if (neutralShipDD.value == 4)
        {
            neutralShipText.text = "A consumer-grade hover-van designed for safety and easy driving. The chosen vehicle of space-soccer moms. Driven by John J. Johnson-Smith Jr. -Speed, +Weight, ++Handling";
        }
        else if (neutralShipDD.value == 5)
        {
            neutralShipText.text = "A lightweight craft used by Karkarians on the swamps of their home planet, Aquarius. Ear protection is recommended. Driven by Karkaro. -Speed, -Weight";
        }
        if (neutralShipDD.value == 6)
        {
            neutralShipText.text = "An ultra-fast prototype hovership stolen from the Karkarians. Held together through quantum entanglemant. Driven by Calypso Wyght. +Speed, -Weight";
        }
        else if (neutralShipDD.value == 7)
        {
            neutralShipText.text = "A jury-rigged drill used by the Astro Mining Company to collect rare minerals from the rings of Saturn. Worker safety not ensured. Driven by John J. Johnson-Smith. ++Weight, ++Handling";
        }


        if (trackDD.value == 0)
        {
            trackText.text = "A patch of desert outside Turbo City where the Karkarian ship crashed. 3 laps. 30 Crystals.";
        }
        else if (trackDD.value == 1)
        {
            trackText.text = "A simple oval used for the Speedway Races. 4 laps. 20 Crystals.";
        }
        else if (trackDD.value == 2)
        {
            trackText.text = "The dense, crisscrossing streets of Turbo City. 2 laps. 40 Crystals.";
        }
        else if (trackDD.value == 3)
        {
            trackText.text = "A mysterious track seen only in dreams. 6 laps. 0 Crystals.";
        }
        else if (trackDD.value == 4)
        {
            trackText.text = "The launching bay for Karkarian spaceships. 2 laps. 40 Crystals.";
        }
        else if (trackDD.value == 5)
        {
            trackText.text = "An asteroid hollowed out by the Astro Mining Company. 3 laps. 30 Crystals.";
        }
    }

    public void openMenu()
    {
        modeSelectPanel.SetActive(true);
        openingNarration.SetActive(false);
    }
}
