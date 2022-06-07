using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falseArea : MonoBehaviour
{
    // Start is called before the first frame update
    public FlagCount flagHandler;
    public MistakeFlag mistakeHandler;

    public AudioClip wrongsound;

    public GameObject missionArea;

    public void scoreMinus(){
        //  ScoreSystem.score -= 100;
         GetComponent<AudioSource>().PlayOneShot(wrongsound);
         flagHandler.bonusFlag = 0;
         mistakeHandler.mistakeFlag += 1;
         if(mistakeHandler.mistakeFlag == 3){
             SceneManager.LoadScene("Scene_Game");
         }
    }

    public void OnTriggerEnter(Collider other){
         scoreMinus();
        }
        private void OnTriggerExit(Collider other) 
    {
        missionArea.gameObject.SetActive (false);
        }
}
