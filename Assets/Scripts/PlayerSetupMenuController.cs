using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetupMenuController : MonoBehaviour
{
    private int playerIndex;

    [SerializeField]
    private TextMeshProUGUI titleText;
    [SerializeField]
    private GameObject readyPanel;
    [SerializeField]
    private GameObject menuPanel;
    [SerializeField]
    private Button readyButton;

    private float ignoreInputTime = 1.5f;
    private bool inputEnabled;
    public void setPlayerIndex(int pi)
    {
        playerIndex = pi;
        titleText.SetText("Player " + (pi + 1).ToString());
        ignoreInputTime = Time.time + ignoreInputTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        inputEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > ignoreInputTime)
        {
            inputEnabled = true;
        }
    }

    //parameter needs to be changed to some other type that represents the ship
    //then changed in the editor under the button objects
    public void SelectColor() //(Material mat)
    {
        //if (!inputEnabled) { return; }

        //remove this
        Material mat = null;

        //SET PLAYER SHIP
        //requires some work in the buttons in the editor, 32 mins in video => https://www.youtube.com/watch?v=_5pOiYHJgl0
        PlayerConfigurationManager.Instance.SetPlayerColor(playerIndex, mat);
        readyPanel.SetActive(true);
        readyButton.interactable = true;
        menuPanel.SetActive(false);
        readyButton.Select();

    }

    //called by the unity event in the editor
    public void ReadyPlayer()
    {
        Debug.Log("player hit ready button");
        //if (!inputEnabled) { return; }

        PlayerConfigurationManager.Instance.ReadyPlayer(playerIndex);
        readyButton.gameObject.SetActive(false);
    }
}