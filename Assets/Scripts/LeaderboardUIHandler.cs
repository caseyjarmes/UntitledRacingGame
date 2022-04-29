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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateList(Dictionary<int,PlayerStats> players)
    {
        foreach (KeyValuePair<int, PlayerStats> pos in Leaderboard.lb.OrderByDescending(key => key.Value.position).ThenBy(key => key.Value.TimeEntered))
        {
            leaderboardUIElements[pos.Value.position].SetName(pos.Value.name);
        }
    }
    void FixedUpdate()
    {
        UpdateList(Leaderboard.lb);
    }
}
