using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charIcon : MonoBehaviour
{

    public GameObject imageTagHandler;

    public Image image;
    private Sprite jankenIcon;
    void Update()
    {
        if(imageTagHandler.tag == "Paper"){
            this.tag = "Paper";
        } else if(imageTagHandler.tag == "Scissors"){
            this.tag = "Scissors";
        } else if(imageTagHandler.tag == "Stone"){
            this.tag = "Stone";
        } 
        if(this.tag == "Scissors"){
            jankenIcon = Resources.Load<Sprite>("scissors");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        } else if(this.tag == "Paper"){
            jankenIcon = Resources.Load<Sprite>("paper");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        } else if(this.tag == "Stone"){
            jankenIcon = Resources.Load<Sprite>("stone");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        }
    }
}
