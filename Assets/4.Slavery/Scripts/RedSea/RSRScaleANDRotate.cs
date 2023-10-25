using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSRScaleANDRotate : MonoBehaviour
{
    public GameObject HatInteractive, CrossInteractive; //red sea

    bool _ZoomIn;
    bool _ZoomOut;

    //object scale speed
     public float rotateSpeed = 50f;
	 bool rotateStatus = false;
     public static bool Isenabled;

     //rotate object function
	public void RotateObject()
	{

		if (rotateStatus == false)
		{
			rotateStatus = true;
		}
		else
		{
			rotateStatus = false;
		}
	}

     // Update is called once per frame
    void  Update()
    {
        if(Isenabled){
        if (_ZoomIn)
        {
            //redsea 
             switch (RedSea.currentTxt)
            {
                case "HatTalk":
                HatInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "CrossTalk":
                CrossInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (_ZoomOut)
        {
            //redsea 
             switch (RedSea.currentTxt)
            {
                case "HatTalk":
                HatInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "CrossTalk":
                CrossInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (rotateStatus == true)
		{
           //redsea 
             switch (RedSea.currentTxt)
            {
                case "HatTalk":
                HatInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "CrossTalk":
                CrossInteractive.transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
                //https://docs.unity3d.com/ScriptReference/Vector3.html
                break;

                default:
                break;
                
            }
			
		}  
        
    }else{
        rotateStatus = false;
    }
    }

    
  

    //Make object scaled big
    public void OnPressZoomIn()
    {
        _ZoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        _ZoomIn = false;
    }

    //Make object scaled small
    public void OnPressZoomOut()
    {
        _ZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }
}
