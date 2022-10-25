using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShot : MonoBehaviour
{   



    public void takescreenShot() {
        StartCoroutine("screenShot");
    }

    private IEnumerator screenShot() {
        yield return new WaitForEndOfFrame();
        Texture2D screenShot = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
        screenShot.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
        screenShot.Apply();
        byte[] bytes = screenShot.EncodeToPNG();
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        File.WriteAllBytes(Application.dataPath + "/Screenshot" + timeStamp + ".png", bytes);

        Destroy(screenShot);
        // string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        // string filePath = Path.Combine( Application.persistentDataPath, "Tanks" + timeStamp + ".png" );
    }
}

