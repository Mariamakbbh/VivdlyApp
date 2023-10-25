using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public static string objectToScale; 
    
    //items ghana
    public GameObject Snake;
    public GameObject Kora;
    public GameObject Griot;
    public GameObject Dinga;
    public GameObject Islam;
    public GameObject Gold; 

    //mali
    public GameObject mansa;
    public GameObject muslim; 
   // public GameObject// terrain; 

   //mali
    public GameObject Songhai;

     bool _ZoomIn;
     bool _ZoomOut;

    //object scale speed
     float Scale = 95f;

public void InteractiveModels(bool setting)
    {
        Snake.SetActive(setting);    
        Kora.SetActive(setting); 
        Griot.SetActive(setting); 
        Dinga.SetActive(setting); 
        Islam.SetActive(setting); 
        Gold.SetActive(setting); 
    }
    
    public void SnakeOn()
    {
        InteractiveModels(false);
        print("Interacrive models Off");
        Snake.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Snake active");
    }
    public void KoraOn()
    {  
        InteractiveModels(false);
        print("Interacrive models Off");
        Kora.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Kora active");
    }
    public void GriotOn()
    {
        InteractiveModels(false);
        print("Interacrive models Off");
        Griot.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Griot active");
    }
    public void DingaOn()
    {
        InteractiveModels(false);
        print("Interacrive models Off");
        Dinga.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Dinga active");
    }
    public void IslamOn()
    {
        InteractiveModels(false);
        print("Interacrive models Off");
        Islam.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Islam active");
    }
    public void GoldOn()
    {
        InteractiveModels(false);
        print("Interacrive models Off");
        Gold.SetActive(true);
       // terrain.SetActive(true);
        print("Scales: Gold active");
    }

//mali
    public void MusaOn()
    {
        mansa.SetActive(true);
        muslim.SetActive(false);
    }

    public void MuslimOn()
    {
        muslim.SetActive(true);
        mansa.SetActive(false);
    }
    public void MaliOn()
    {
        muslim.SetActive(true);
        mansa.SetActive(true);
    }

    
    // Update is called once per frame
    void  Update()
    {
        if (_ZoomIn)
        {
            //make a bigger object
            switch (objectToScale)
            {
                case "Snake":
                print("Snake ScaleUP");  
                Snake.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                case "Kora":
                print("Kora ScaleUP");  
                Kora.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                break;

                case "Griot":
                print("Griot ScaleUP");  
                Griot.transform.localScale += new Vector3(5f, 5f, 5f);
                break;

                case "Dinga":
                print("Dinga ScaleUP");  
                Dinga.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                case "Islam":
                print("Islam ScaleUP");  
                Islam.transform.localScale += new Vector3(100f, 100f, 100f);
                break;

                case "Gold":
                print("Gold ScaleUP");  
                Gold.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                //Mali
                case "Musa":
                mansa.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                case "Muslim":
                muslim.transform.localScale += new Vector3(Scale, Scale, Scale);
                break;

                //songhai
                case "Songhai":
                print("Songhai ScaleUP");  
                Songhai.transform.localScale += new Vector3(20f, 20f, 20f);

                break;

                default:
                break;
                
            }
        }

        if (_ZoomOut)
        {
            //make a small object
            switch (objectToScale)
            {
                case "Snake":
                Snake.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                case "Kora":
                Kora.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
                break;

                case "Griot": 
                Griot.transform.localScale -= new Vector3(5f, 5f, 5f);
                break;

                case "Dinga":
                Dinga.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                case "Islam":
                Islam.transform.localScale -= new Vector3(100f, 100f, 100f);
                break;

                case "Gold": 
                Gold.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                //Mali
                case "Musa":
                mansa.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                case "Muslim":
                muslim.transform.localScale -= new Vector3(Scale, Scale, Scale);
                break;

                //songhai
                case "Songhai":
                Songhai.transform.localScale -= new Vector3(20f, 20f, 20f);
                break;

                default:
                break;
                
            }
        }
        
    }
    public void ResertSizeMali(){
        //Mali

        muslim.transform.localScale = new Vector3(0.8951803f,0.5f, 0.976859f);
        //muslim.transform.position = new Vector3(0.05818789f, 0f, -0.04624432f); 
       // muslim.transform.eulerAngles = new Vector3(0f,0f,0f);

        mansa.transform.localScale = new Vector3(0.8951803f,0.5f,0.976859f);
        //mansa.transform.position = new Vector3(0.3625493f,0f,1.846908f);
        //mansa.transform.eulerAngles = new Vector3(0f,0f,0f);
        
    }

   
    public void ResertSizeMSon(){

        Songhai.transform.localScale = new Vector3(0.9948474f, 1f, 0.8240726f);
       // Songhai.transform.position = new Vector3(0.0977f, 0f, 8.3467f);
        //Songhai.transform.eulerAngles = new Vector3(0f,0f,0f);
      

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