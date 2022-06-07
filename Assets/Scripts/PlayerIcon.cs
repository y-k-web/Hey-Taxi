using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIcon : MonoBehaviour
{

    public Car CarTagHandler;
    private Sprite jankenIcon;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CarTagHandler.tag == "Scissors"){
            jankenIcon = Resources.Load<Sprite>("scissors_pl");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        } else if(CarTagHandler.tag == "Paper"){
            jankenIcon = Resources.Load<Sprite>("paper_pl");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        } else if(CarTagHandler.tag == "Stone"){
            jankenIcon = Resources.Load<Sprite>("stone_pl");
            image = this.GetComponent<Image>();
            image.sprite = jankenIcon;
        }
    }
}
