using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlagCount : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public TMP_Text flagCounter;
    [SerializeField] public float flagMultiplier;

    public float bonusFlag;
    // Update is called once per frame
    public void Update()
    {
        flagCounter.text = "Flag: " + Mathf.FloorToInt(bonusFlag).ToString();
    }
}
