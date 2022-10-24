using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShot : MonoBehaviour
{   

    [SerializeField]
    GameObject blink;

    public void ClickShare() {
        StartCoroutine(TakeScreenShot());
    }

    IEnumerator TakeScreenShot() {
        string fileName = "score.png";
        string pathToSave = fileName;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
        Instantiate (blink, new Vector2(0f, 0f), Quaternion.identity);
    }
}
