using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtlanticScaleANDRotate : MonoBehaviour
{
    public GameObject AfricaName, GoldCoast, GoldCoastBoat, Masjid, Jesus, Mask, King, LatinA, Triangle, Portugese, WithdrawalCost, BritishAbolish, WithdrawalCostWait;


    //ISLAND
    public GameObject IslandClicked, Fight, InsideShip, WalkJourney, Abuse, Drown;

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
             switch (Atlantic.currentTxt)
            {
                case "AfricaNameTalk":
                AfricaName.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldCoastTalk":
                GoldCoast.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldCoastBoatTalk":
                GoldCoastBoat.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MasjidTalk":
                Masjid.transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "JesusTalk":
                Jesus.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MasksTalk":
                Mask.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "KingTalk":
                King.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LatinATalk":
                LatinA.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TriangleTalk":
                Triangle.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "PortugeseTalk":
                Portugese.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WithdrawalCostTalk":
                WithdrawalCost.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "BritishAbolishTalk":
                BritishAbolish.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WithdrawalCostWaitTalk":
                WithdrawalCostWait.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;


                //Island

                case "IslandTalk":
                IslandClicked.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "FightTalk":
                Fight.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "InsideShipTalk":
                InsideShip.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WalkJourneyTalk":
                WalkJourney.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "AbuseTalk":
                Abuse.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "DrownTalk":
                Drown.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (_ZoomOut)
        {
             switch (Atlantic.currentTxt)
            {
                case "AfricaNameTalk":
                AfricaName.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldCoastTalk":
                GoldCoast.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "GoldCoastBoatTalk":
                GoldCoastBoat.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MasjidTalk":
                Masjid.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                break;

                case "JesusTalk":
                Jesus.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "MasksTalk":
                Mask.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "KingTalk":
                King.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "LatinATalk":
                LatinA.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "TriangleTalk":
                Triangle.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "PortugeseTalk":
                Portugese.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WithdrawalCostTalk":
                WithdrawalCost.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "BritishAbolishTalk":
                BritishAbolish.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WithdrawalCostWaitTalk":
                WithdrawalCostWait.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                //ISLAND
                case "IslandTalk":
                IslandClicked.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "FightTalk":
                Fight.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "InsideShipTalk":
                InsideShip.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "WalkJourneyTalk":
                WalkJourney.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "AbuseTalk":
                Abuse.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                case "DrownTalk":
                Drown.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                break;

                default:
                break;
                
            }
        }

        if (rotateStatus == true)
		{
             switch (Atlantic.currentTxt)
            {
                case "AfricaNameTalk":
                AfricaName.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "GoldCoastTalk":
                GoldCoast.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "GoldCoastBoatTalk":
                GoldCoastBoat.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MasjidTalk":
                Masjid.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "JesusTalk":
                Jesus.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "MasksTalk":
                Mask.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "KingTalk":
                King.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "LatinATalk":
                LatinA.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "TriangleTalk":
                Triangle.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "PortugeseTalk":
                Portugese.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "WithdrawalCostTalk":
                WithdrawalCost.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "BritishAbolishTalk":
                BritishAbolish.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "WithdrawalCostWaitTalk":
                WithdrawalCostWait.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                //ISLAND
                case "IslandTalk":
                IslandClicked.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "FightTalk":
                Fight.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "InsideShipTalk":
                InsideShip.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "WalkJourneyTalk":
                WalkJourney.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "AbuseTalk":
                Abuse.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
                break;

                case "DrownTalk":
                Drown.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
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
