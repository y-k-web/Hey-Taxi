using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenButton : MonoBehaviour
{
    GameObject playertag;
    GameObject jankentag;
   
    void Start(){
         playertag = GameObject.Find("Car");
        //  jankentag = GameObject.Find("Scissors");
    }
    public void taghandler(){

        if (this.tag == "Scissors"){
            playertag.tag = "Scissors";
        } else if (this.tag == "Stone"){
            playertag.tag = "Stone";
        }else if (this.tag == "Paper"){
            playertag.tag = "Paper";
        }
    }
}
