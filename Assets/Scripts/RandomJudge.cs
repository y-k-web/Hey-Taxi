using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomJudge : MonoBehaviour
{
    public GameObject chartag;
    
    string[] mission = {"あいこ", "勝とう", "負けよう"};
    string[] Janken = {"Scissors", "Stone", "Paper"};

    public GameObject missionTag;
    GameObject missiontxt;
    public string missionHandler;
    public int randomHandler = 0;
    public int randomTagHandler = 0;

       void Start(){
         randomHandler = Random.Range(0,3);
         randomTagHandler = Random.Range(0,3);
         missiontxt = GameObject.Find("mission_text");
         missiontxt.GetComponent<Text>().text = null;
    }
    public void OnTriggerEnter(Collider other) 
    {
        chartag.tag = Janken[randomTagHandler];
        missionHandler = mission[randomHandler];
        Debug.Log(missionHandler);
        missiontxt.GetComponent<Text>().text = missionHandler;

        if (missionHandler == "あいこ"){
          missionTag.tag = "Draw";
        } else if (missionHandler == "勝とう"){
          missionTag.tag = "Win";
        } else if (missionHandler == "負けよう"){
          missionTag.tag = "Lose";
        }
     }
}