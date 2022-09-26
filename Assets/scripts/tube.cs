using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(-4.0f*Time.deltaTime,0,0); 

         if(transform.position.x< -10.0f){

         Destroy(gameObject);
           transform.parent.GetComponent<tubemanger>().Spawntube();
         }

         }
    }

