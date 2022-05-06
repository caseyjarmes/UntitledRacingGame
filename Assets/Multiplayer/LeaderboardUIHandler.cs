using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class LeaderboardUIHandler : MonoBehaviour
{
    public GameObject ScoreboardElementPrefab;

    LeaderboardUIElement[] leaderboardUIElements;
    void Awake()
    {
        VerticalLayoutGroup Layout = GetComponentInChildren<VerticalLayoutGroup>();

        leaderboardUIElements = new LeaderboardUIElement[Leaderboard.lb.Count];

        for(int i = 0; i < Leaderboard.lb.Count; i++)
        {
            GameObject creatingUIElement = Instantiate(ScoreboardElementPrefab, Layout.transform);

            leaderboardUIElements[i] = creatingUIElement.GetComponent<LeaderboardUIElement>();

            leaderboardUIElements[i].SetPositionText($"{i+1}.");
        }
    }

    public void UpdateList(Dictionary<int,PlayerStats> players)
    {
        //for(int i= -1; i < players.Count; i++)
        //{
        //    leaderboardUIElements[i + 1].SetName(players[i+1].name);
        //    leaderboardUIElements[i + 1].SetCrystalCollected(players[i + 1].Collected.ToString());
        //    leaderboardUIElements[i + 1].SetBestTime(players[i + 1].BestTime);
        //}
        foreach (KeyValuePair<int, PlayerStats> pos in Leaderboard.lb.OrderByDescending(key => key.Value.position).ThenByDescending(key => key.Value.TimeEntered))
        {
            leaderboardUIElements[pos.Value.position-1].SetName(pos.Value.name);
            leaderboardUIElements[pos.Value.position-1].SetCrystalCollected(pos.Value.Collected.ToString());
            leaderboardUIElements[pos.Value.position-1].SetBestTime(pos.Value.BestTime);
        }
    }
    void FixedUpdate()
    {
        UpdateList(Leaderboard.lb);
    }
}
