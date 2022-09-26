using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   

    bool birdDead;
  
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        

 if(Input.touchCount>0){

transform.Translate(0,10.0f*Time.deltaTime,0); 


void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("Coins")) {
        Destroy(other.gameObject);
    }
}

}             
else 
{
    transform.Translate(0,-1.0f*Time.deltaTime,0);  
}


    }



 void OnTriggerEnter2D(Collider2D other) {

   if (other.gameObject.tag == "death")
    {

        Debug.Log("lost");
         birdDead = true;
        GameManger.lostgame(birdDead);
     
    }
  
}
 



}
