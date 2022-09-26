using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubemanger : MonoBehaviour
{

    [SerializeField]GameObject[] tubeprefabs;
public void Spawntube(){

int r = Random.Range(0,tubeprefabs.Length);
GameObject tube =Instantiate(tubeprefabs[r],transform);
tube.transform.position = new Vector3(9.0f,Random.Range(-5.0f,6.5f),0);
}
 
}
