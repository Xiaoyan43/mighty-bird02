using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
   //main game is level 1
   public void RetryGame() {
      SceneManager.LoadScene(1);
   }

   public void ExitGame() {
    Application.Quit();
   }

   //shop is level 2
   public void Shop() {
      SceneManager.LoadScene(2);
   }

}
