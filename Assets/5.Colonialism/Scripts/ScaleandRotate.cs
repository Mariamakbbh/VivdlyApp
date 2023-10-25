using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleandRotate : MonoBehaviour
{
    public GameObject Table, King, NaturalRes, ScumblePercent, ScumbleInfo, Languages, Culture, population;
    public GameObject Irish, Military, European, Roman, Black;

    

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
            switch (Coloni.currentTxt)
            {
                case "TableTalk":
                Table.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LeoTalk":
                King.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "NaturalResTitle":
                NaturalRes.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ScumblePercentTalk":
                ScumblePercent.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ScumbleInfoTalk":
                ScumbleInfo.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LangauegsTalk": 
                Languages.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TibeTalk":
                Culture.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "populationTalk":
                population.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "blackTalk":
                Black.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MilitaryTalk":
                Military.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                break;
                
                case "romanTalk":
                Roman.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "EuropeanTalk":
                European.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "IrishTalk":
                Irish.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
            
        }

        if (_ZoomOut)
        {
            //make a small object
            switch (Coloni.currentTxt)
            {
                case "TableTalk":
                Table.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LeoTalk":  
                King.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "NaturalResTitle":
                NaturalRes.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ScumblePercentTalk":
                ScumblePercent.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ScumbleInfoTalk":
                ScumbleInfo.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LangauegsTalk": 
                Languages.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TibeTalk":
                Culture.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "populationTalk":
                population.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "blackTalk":
                Black.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MilitaryTalk":
                Military.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;
                
                case "romanTalk":
                Roman.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "EuropeanTalk":
                European.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "IrishTalk":
                Irish.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }

        }

        if (rotateStatus == true)
		{
          
            switch (Coloni.currentTxt)
            {
                case "TableTalk":
                Table.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "LeoTalk": 
                King.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "NaturalResTitle":
                NaturalRes.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "ScumblePercentTalk":
                ScumblePercent.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "ScumbleInfoTalk":
                ScumbleInfo.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "LangauegsTalk": 
                Languages.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "TibeTalk":
                Culture.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "populationTalk":
                population.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "blackTalk":
                Black.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MilitaryTalk":
                Military.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;
                
                case "romanTalk":
                Roman.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "EuropeanTalk":
                European.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "IrishTalk":
                Irish.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
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
