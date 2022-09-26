using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum;
    // Start is called before the first frame update
    void Start()
    {
        // scoreNum = 0;
        // myScoreText.text = "Score : " + scoreNum;
    }

    private void onTriggerEnter2D(Collider2D other) {

       if(other.gameObject.CompareTag("coin")) {
        scoreNum++;
        Destroy(other.gameObject);
        }

    }
}
