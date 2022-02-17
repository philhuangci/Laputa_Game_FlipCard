    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreInfo : MonoBehaviour
{
    public TextMeshProUGUI ScoreNorth;
    public TextMeshProUGUI ScoreEast;
    public TextMeshProUGUI ScoreSouth;
    public TextMeshProUGUI ScoreWest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int scoreNorth, int scoreEast, int scoreSouth, int scoreWest)
    {
        ScoreNorth.text = "X" + scoreNorth;
        ScoreEast.text = "X" + scoreEast;
        ScoreSouth.text = "X" + scoreSouth;
        ScoreWest.text = "X" + scoreWest;
    }

}
