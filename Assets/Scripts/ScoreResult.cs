using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    public Text ScoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
    score = JankenJudge.getScore();
    ScoreText.text = string.Format("スコア:{0}",score);
    }

    // Update is called once per frame
    // void Update()
    // {
    // }
}
