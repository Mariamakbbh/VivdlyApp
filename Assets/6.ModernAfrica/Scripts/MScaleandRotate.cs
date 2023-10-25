using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MScaleandRotate : MonoBehaviour
{
    public GameObject Conflict, people, land, trust, religions;
    public GameObject India, SriLanka, Mediterranean, Venezuela, Canada, Britain, Argentina, Russian, Brazil, Migration, Racism, Colourism, BloodPressure;
    public GameObject Rosa, GeorgeF, FredHampton, Breonna, MalcomeX, MLK, Mandel;

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
            switch (Modern.currentTxt)
            {
                case "ConflictTalk":
                Conflict.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "TrustTalk":
                trust.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "ReligionsTalk":
                religions.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "LandTalk":
                land.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "peopleTalk":
                people.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                break;

                //DIASPORA
                case "IndiaTalk":
                India.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SriLankaTalk":
                SriLanka.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;
                
                case "MediterraneanTalk":
                Mediterranean.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "VenezuelaTalk":
                Venezuela.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "CanadaTalk":
                Canada.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BritainTalk":
                Britain.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "ArgentinaTalk":
                Argentina.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "RussianTalk":
                Russian.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BrazilTalk":
                Brazil.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MigrationTalk":
                Migration.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "RacismTalk":
                Racism.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ColourismTalk":
                Colourism.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BloodPressureTalk":
                BloodPressure.transform.localScale += new Vector3(1f, 1f, 1f);
                break;
//HEROS
                case "RosaTalk":
                Rosa.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "GeorgeFTalk":
                GeorgeF.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "FredHamptonTalk":
                FredHampton.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "BreonnaTalk":
                Breonna.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "MalcomeXTalk":
                MalcomeX.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "MLKTalk":
                MLK.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                case "MandelaTalk":
                Mandel.transform.localScale += new Vector3(1f, 1f, 1f);
                break;

                default:
                break;
                
            }
            
        }

        if (_ZoomOut)
        {
            //make a small object
            switch (Modern.currentTxt)
            {
                case "ConflictTalk":
                Conflict.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "TrustTalk":
                trust.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "ReligionsTalk":
                religions.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "LandTalk":
                land.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "peopleTalk":
                people.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;

                //DIASPORA
                case "IndiaTalk":
                India.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "SriLankaTalk":
                SriLanka.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;
                
                case "MediterraneanTalk":
                Mediterranean.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "VenezuelaTalk":
                Venezuela.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "CanadaTalk":
                Canada.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BritainTalk":
                Britain.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "ArgentinaTalk":
                Argentina.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "RussianTalk":
                Russian.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BrazilTalk":
                Brazil.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MigrationTalk":
                Migration.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "RacismTalk":
                Racism.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "ColourismTalk":
                Colourism.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                break;

                case "BloodPressureTalk":
                BloodPressure.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;
//HEROS
                case "RosaTalk":
                Rosa.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "GeorgeFTalk":
                GeorgeF.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "FredHamptonTalk":
                FredHampton.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "BreonnaTalk":
                Breonna.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "MalcomeXTalk":
                MalcomeX.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "MLKTalk":
                MLK.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                case "MandelaTalk":
                Mandel.transform.localScale -= new Vector3(1f, 1f, 1f);
                break;

                default:
                break;
                
            }

        }

        if (rotateStatus == true)
		{
          
            switch (Modern.currentTxt)
            {
                case "ConflictTalk":
                Conflict.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "TrustTalk":
                trust.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "ReligionsTalk":
                religions.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "LandTalk":
                land.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "peopleTalk":
                people.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                //DIASPORA
                case "IndiaTalk":
                India.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "SriLankaTalk":
                SriLanka.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;
                
                case "MediterraneanTalk":
                Mediterranean.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "VenezuelaTalk":
                Venezuela.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "CanadaTalk":
                Canada.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BritainTalk":
                Britain.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "ArgentinaTalk":
                Argentina.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "RussianTalk":
                Russian.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BrazilTalk":
                Brazil.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MigrationTalk":
                Migration.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "RacismTalk":
                Racism.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "ColourismTalk":
                Colourism.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BloodPressureTalk":
                BloodPressure.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

//HEROS
                case "RosaTalk":
                Rosa.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "GeorgeFTalk":
                GeorgeF.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "FredHamptonTalk":
                FredHampton.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BreonnaTalk":
                Breonna.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MalcomeXTalk":
                MalcomeX.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MLKTalk":
                MLK.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MandelaTalk":
                Mandel.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
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
