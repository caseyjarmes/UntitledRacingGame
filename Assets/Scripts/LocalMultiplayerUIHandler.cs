using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMultiplayerUIHandler : MonoBehaviour
{
    public List<UiInGameTimeController> controllers = new List<UiInGameTimeController>();
    public List<ShipStatsUI> playerStats = new List<ShipStatsUI>();
    public List<CinemachineManipulator> manipulators = new List<CinemachineManipulator>();
    // Start is called before the first frame update
    void Start()
    {
        // GameObject.FindObjectOfType<uic>
        // var players = GameObject.FindGameObjectsWithTag("Player");
        // var Stats = GameObject.FindGameObjectsWithTag("LocalStatsUI");
        // var UIs = GameObject.FindGameObjectsWithTag("LocalUI");
        // var playerCams = GameObject.FindGameObjectsWithTag("MultiplayerCam");
        // FindObjectwithTag(controllers,"");
        // for(int i = 0; i < controllers;i++) {            
        //     controllers[i] = UIs[i].GetComponent<UiInGameTimeController>();
        //     controllers[i].LapTimeManager = players[i].GetComponent<LapTimeManager>();
        //     manipulators[i] = playerCams[i].GetComponent<CinemachineManipulator>();            
        //     playerStats[i] = Stats[i].GetComponent<ShipStatsUI>();
        //     manipulators[i].CarControl = playerStats[i].CarControl = players[i].GetComponent<CarControl>();
        // }
        // GameObject.Find("").GetComponentsInChildren<UiInGameTimeController>();.
    }
 
     public void FindObjectwithTag(string _tag)
     {
         Transform parent = transform;
         GetChildObject(parent, _tag);
     }
 
     public void GetChildObject(Transform parent, string _tag)
     {
        //  for (int i = 0; i < parent.childCount; i++)
        //  {
        //      Transform child = parent.GetChild(i);
        //      if (child.tag == _tag)
        //      {
        //          .Add(child.gameObject);
        //      }
        //      if (child.childCount > 0)
        //      {
        //          GetChildObject(child, _tag);
        //      }
        //  }
     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
