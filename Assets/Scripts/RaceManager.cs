using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceManager : MonoBehaviour
{
    //public static int TotalLapsRequired;
    private int FinishedCount = 0;
    LapTimeManager[] ShipsLTM;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] ships = GameObject.FindGameObjectsWithTag("Player");
        ShipsLTM = new LapTimeManager[ships.Length];
        for (int i = 0; i < ships.Length; i++){
            ShipsLTM[i] = ships[i].GetComponent<LapTimeManager>();
        }
    }
    //IEnumerator StartupSequence()
    //{
    //    //var inputhandler = GameObject.FindGameObjectsWithTag("");
    //    var players = GameObject.FindGameObjectsWithTag("Player");
    //    foreach (GameObject player in players)
    //    {
    //        var input = player.GetComponent<CarControl>();
    //        input.enabled = false;
    //        start.Play();
    //    }
    //    var count = 4;
    //    while (count > 0)
    //    {
    //        players = GameObject.FindGameObjectsWithTag("Player");
    //        UIStartup.text = $"{count - 1}";
    //        // start.Play();
    //        if (count == 1)
    //        {
    //            UIStartup.text = "GO!";
    //            foreach (GameObject player in players)
    //            {
    //                var input = player.GetComponent<CarControl>();
    //                input.enabled = true;
    //            }
    //            Started = true;

    //        }
    //        StartedData = Started;
    //        yield return new WaitForSeconds(1f);
    //        --count;
    //    }

    //    yield return null;
    //    if (UIStartup.IsActive())
    //        UIStartup.gameObject.SetActive(false);
    //}
    
    public void RestartLevel()
    {
        //reset static values that are not level specific
        Leaderboard.ResetInfo();
        LapTimeManager.Completedgame = false;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    void LateUpdate()
    {
        foreach(LapTimeManager ltm in ShipsLTM)
        {
            if (ltm.completedgame)
            {
                FinishedCount++;
            }
        }
        if(FinishedCount == ShipsLTM.Length)
        {
            //set ui stuff to false
            //change end screen to show
        }
    }
}
