using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float waitTime = 8f;
    public static bool isStart;
    
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        isStart = true;
        StartCoroutine(pause());
    }

    IEnumerator pause(){
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(1);
   

    }

  
}
