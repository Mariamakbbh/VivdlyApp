using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    public static string objectToRotate; 
    public static bool Isenabled;

    //items
    public GameObject Snake;
    public GameObject Kora;
    public GameObject Griot;
    public GameObject Dinga;
    public GameObject Islam;
    public GameObject Gold;  

    //mali
    public GameObject Musa;
    public GameObject Muslim; 

     //Songhai
    public GameObject Songhai;

	public float rotateSpeed = 50f;
	 bool rotateStatus = false;
     public static bool Notrotate = false;

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

	 void  Update()
	{
        if(Isenabled){
		if (rotateStatus == true)
		{
          
            switch (objectToRotate)
            {
                case "Snake":
                Snake.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Kora": 
                Kora.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Griot":
                Griot.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Dinga":
                Dinga.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Islam": 
                Islam.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Gold":
                Gold.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Musa":
                Musa.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Muslim":
                Muslim.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "Songhai":
                Songhai.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;
                
           }
			
		}  
        
       
	}else{
        rotateStatus = false;
    }
    }

    public void NotRotateObject()
	{
		rotateStatus = false;
        
        Muslim.transform.Rotate(0f,0f,0f);
        Musa.transform.Rotate(0f,0f,0f);
        Songhai.transform.Rotate(0f,0f,0f);
	}

}