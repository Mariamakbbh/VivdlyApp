using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenLandscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	  if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("Do something special here!");
        }else{
	        
            Screen.SetResolution(1280,720, true);
            Debug.Log("NOT ANDROID!");
            //left
        }
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

}
