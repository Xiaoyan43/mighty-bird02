using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    static GameManger instance;
    // Start is called before the first frame update
    public Text timeScore;
    public GameObject gamnOverUI;
    public void   Awake() {
        if(instance != null){

            Destroy(gameObject);
        }
        instance= this;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeScore.text = Time.timeSinceLevelLoad.ToString("00");
    }



    public void RestartGame(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
Time.timeScale =1;

    }

      public void Exit(){
Application.Quit();

    }

public static void lostgame(bool lost){

if(lost){
    instance.gamnOverUI.SetActive(true);
    Time.timeScale = 0f;
}


}





}









