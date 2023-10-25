using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaharaScaleANDRotate : MonoBehaviour
{
    public GameObject PrayerInteractive, SaharaInteractive, SlaveInteractive, CaravanInteractive;
    public GameObject WhiteSlaveInteractive, BlackSlaveInteractive, WomenSlaveInteractive, QuranInteractive, MomInteractive, LeavingInteractive, DeadInteractive, NonMuslimInteractive;

    //SUDAN
    public GameObject MediterInteractive, KidnapInteractive, GoldInteractive, TradeInteractive;

    bool _ZoomIn;
    bool _ZoomOut;

    //object scale speed
    float Scale = 1f;
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
            switch (saharaScene.currentTxt)
            {
                case "PrayerTalk":
                PrayerInteractive.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                case "SlaveAmountTalk":
                SlaveInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SaharaTalk":
                SaharaInteractive.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "CaravanTalk":
                CaravanInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                                   //NA
                case "WhiteSlavesTalk": 
                WhiteSlaveInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "BlackSlaveTalk": 
                BlackSlaveInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveGirlsTalk":
                WomenSlaveInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "QuranTalk": 
                QuranInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SingleMomTalk":
                MomInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveLeaveTalk": 
                LeavingInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "DeadTalk": 
                DeadInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "NonMuslimTalk": 
                NonMuslimInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MediterInteractiveTalk": 
                MediterInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "KidnapInteractiveTalk": 
                KidnapInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldInteractiveTalk": 
                GoldInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TradeInteractiveTalk": 
                TradeInteractive.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (_ZoomOut)
        {
            //make a small object
            switch (saharaScene.currentTxt)
            {
                case "PrayerTalk":
                print(" ScaleUP");  
                PrayerInteractive.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                case "SlaveAmountTalk":
                print(" ScaleUP");  
                SlaveInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SaharaTalk":
                print(" ScaleUP");  
                SaharaInteractive.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "CaravanTalk":
                print(" ScaleUP");  
                CaravanInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                                                   //NA
                case "WhiteSlavesTalk":
                WhiteSlaveInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "BlackSlaveTalk":
                BlackSlaveInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveGirlsTalk":
                WomenSlaveInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "QuranTalk":
                QuranInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SingleMomTalk":  
                MomInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SlaveLeaveTalk":  
                LeavingInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "DeadTalk":
                DeadInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "NonMuslimTalk":
                NonMuslimInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MediterInteractiveTalk": 
                MediterInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "KidnapInteractiveTalk": 
                KidnapInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldInteractiveTalk": 
                GoldInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TradeInteractiveTalk": 
                TradeInteractive.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (rotateStatus == true)
		{
          
            switch (saharaScene.currentTxt)
            {
                case "PrayerTalk":
                PrayerInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SlaveAmountTalk": 
                SlaveInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SaharaTalk":
                SaharaInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "CaravanTalk":
                CaravanInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                                                                  //NA
                case "WhiteSlavesTalk": 
                WhiteSlaveInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BlackSlaveTalk": 
                BlackSlaveInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SlaveGirlsTalk":
                WomenSlaveInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "QuranTalk":
                QuranInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;
                
                case "SingleMomTalk":
                MomInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SlaveLeaveTalk":
                LeavingInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "DeadTalk":
                DeadInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "NonMuslimTalk": 
                NonMuslimInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MediterInteractiveTalk": 
                MediterInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "KidnapInteractiveTalk": 
                KidnapInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "GoldInteractiveTalk": 
                GoldInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "TradeInteractiveTalk": 
                TradeInteractive.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
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
