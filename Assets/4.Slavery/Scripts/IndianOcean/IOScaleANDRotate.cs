using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOScaleANDRotate : MonoBehaviour
{
    public GameObject IndiaInteractive, ShipInteractive; //io
    

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
            //make a bigger object
            switch (IO.currentTxt)
            {
                case "IndianSlaveTalk":
                IndiaInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveShipTalk":
                ShipInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
            
        }

        if (_ZoomOut)
        {
            //make a small object
            switch (IO.currentTxt)
            {
                case "IndianSlaveTalk":
                IndiaInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveShipTalk":  
                ShipInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }

        }

        if (rotateStatus == true)
		{
          
            switch (IO.currentTxt)
            {
                case "IndianSlaveTalk":
                IndiaInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SlaveShipTalk": 
                ShipInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
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
