using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collision) {
    if(collision.transform.tag == "Player") {
      Destroy(gameObject);
    }

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
    
}
