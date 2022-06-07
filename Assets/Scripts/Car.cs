using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{   
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    

     public int bonusFlag = 0;
     public bool isTouch;
     public CountDown timerHandler;

    private int steerValue;
    // Update is called once per frame
     void Start()
    {
            isTouch = false;
    }
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(!isTouch){
        
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LeftWall")){
            this.speed = 30f;
        }
        else if(other.CompareTag("RightWall"))
        {
            this.speed = 30f;
        }else if(other.CompareTag("CenterWall")){
            this.speed = 30f;
        }
        
    }
    private void OnTriggerStay(Collider other) 
    {
     if(other.CompareTag("LeftWall"))
     {  
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.x += 1f;    // x座標へ0.01加算
        myTransform.position = pos;  // 座標を設定
        isTouch = true;
        gameObject.transform.rotation = Quaternion.identity;
        // steerValue = 0;
     }else if(other.CompareTag("RightWall"))
     {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.x += -1f;    // x座標へ0.01加算
        myTransform.position = pos;  // 座標を設定
        gameObject.transform.rotation = Quaternion.identity;
        
     }else if(other.CompareTag("CenterWall")){
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.z += -5f;    // x座標へ0.01加算
        myTransform.position = pos;  // 座標を設定
        gameObject.transform.rotation = Quaternion.identity;
     
     }else if(other.CompareTag("Finish"))
     {
         SceneManager.LoadScene("Scene_MainMenu");
     }
    }
        private void OnTriggerExit(Collider other) 
    {
     if(other.CompareTag("LeftWall"))
     {  
        isTouch = false;
    }else if(other.CompareTag("RightWall"))
    {
        isTouch = false;
    }
    }
    public void Steer(int value)
    {   
        steerValue = value;
    }
}
