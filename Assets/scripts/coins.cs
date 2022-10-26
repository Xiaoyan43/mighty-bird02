using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coins : MonoBehaviour
{
  
    
    public static int score_num = 0;
    public GameObject  coinScore;
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-4.0f*Time.deltaTime,0,0); 
       

         if(transform.position.x< -10.0f){

         Destroy(gameObject);
           transform.parent.GetComponent<coinmovement>().SpawnCoins();
         }

         }
         void OnTriggerEnter2D(Collider2D other) {

   

     
     if(other.gameObject.tag == "Player") {
      score_num++;
        coinScore.GetComponent<TMP_Text>().text = "COIN:"+score_num.ToString ();
        Destroy(gameObject);
        transform.parent.GetComponent<coinmovement>().SpawnCoins();
    }
    
  
}
    
}
