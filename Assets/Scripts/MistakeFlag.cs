using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MistakeFlag : MonoBehaviour
{
    // Start is called before the first frame update    // Start is called before the first frame update
    [SerializeField] public TMP_Text MistakeCounter;
    [SerializeField] public float MistakeMultiplier;

    public float mistakeFlag;
    // Update is called once per frame
    public void Update()
    {
        MistakeCounter.text = "Miss: " + Mathf.FloorToInt(mistakeFlag).ToString();
    }
}
