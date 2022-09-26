using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmovement : MonoBehaviour
{
    [SerializeField]GameObject[] coinPrefab;
    public void SpawnCoins(){

int r = Random.Range(0,coinPrefab.Length);
GameObject coinSky =Instantiate(coinPrefab[r],transform);
coinSky.transform.position = new Vector3(9.0f, Random.Range(-5.0f,6.5f), 0);
}
 
}
