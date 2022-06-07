using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JankenJudge : MonoBehaviour
{
    public CountDown tbonusHandler;
    public FlagCount flagHandler;
    public MistakeFlag mistakeHandler;
    public AudioClip correctsound;
    public AudioClip wrongsound;
    public GameObject charjudge;
    public GameObject deadLine;

    GameObject missiontxt;

    public static int score = 0;
    public Text ScoreText;

    public static int getScore()
    {
        return score;
    }

    void Start() {
        missiontxt = GameObject.Find("mission_text");
    }
    
    
    
    public void scorePlus(){
         score += 100;
         ScoreText.text = string.Format("{0}",score);
         flagHandler.bonusFlag += 1;
         GetComponent<AudioSource>().PlayOneShot(correctsound);
         deadLine.gameObject.SetActive (false);
         if(flagHandler.bonusFlag == 5){
             tbonusHandler.time += 3.0f;
             flagHandler.bonusFlag = 0;
         }
    }
    public void scoreMinus(){
        //  scoreHandler.score -= 100;
         flagHandler.bonusFlag = 0;
         mistakeHandler.mistakeFlag += 1;
         
         GetComponent<AudioSource>().PlayOneShot(wrongsound);
         deadLine.gameObject.SetActive (false);
         if(mistakeHandler.mistakeFlag == 3){
             SceneManager.LoadScene("ScoreResult");
         }
    }

    public void OnTriggerEnter(Collider other){
        //Draw Case
        if(this.tag == "Draw" && charjudge.tag == "Scissors" && other.CompareTag("Scissors"))
        {  
            scorePlus();
        }else if(this.tag == "Draw" && charjudge.tag == "Paper" && other.CompareTag("Paper"))
        {
            scorePlus();
        }else if(this.tag == "Draw" && charjudge.tag == "Stone" && other.CompareTag("Stone"))
        {
            scorePlus();
        }
        //Win Case
        else if(this.tag == "Win" && charjudge.tag == "Scissors" && other.CompareTag("Stone"))
        {
            scorePlus();
        }else if(this.tag == "Win" && charjudge.tag == "Paper" && other.CompareTag("Scissors"))
        {
            scorePlus();
        }else if(this.tag == "Win" && charjudge.tag == "Stone" && other.CompareTag("Paper"))
        {
            scorePlus();
        }
        //Lose Case
        else if(this.tag == "Lose" && charjudge.tag == "Stone" && other.CompareTag("Scissors"))
        {
            scorePlus();
        }else if(this.tag == "Lose" && charjudge.tag == "Paper" && other.CompareTag("Stone"))
        {
            scorePlus();
        }else if(this.tag == "Lose" && charjudge.tag == "Scissors" && other.CompareTag("Paper"))
        {
            scorePlus();
        }else{
         scoreMinus();
        }
    }
        private void OnTriggerExit(Collider other) 
    {
        this.gameObject.SetActive (false);
        missiontxt.GetComponent<Text>().text = null;
        }
    }
