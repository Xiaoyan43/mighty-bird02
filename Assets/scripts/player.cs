using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   

    bool birdDead;
     public float velocity =1.0f;
    private Rigidbody2D rb;

    public float forcesize = 20.0f;
  
    // Start is called before the first frame update
    void Start()
    {
   rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

if(Input.touchCount>0){

       transform.Translate(0,10.0f*Time.deltaTime,0); 
      }             
      else 
      {
       transform.Translate(0,-1.0f*Time.deltaTime,0);  
      }

      if(Input.GetMouseButtonDown(0)){
            rb.AddForce(transform.up * forcesize);
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
