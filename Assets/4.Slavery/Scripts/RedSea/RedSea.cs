using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSea : MonoBehaviour
{
    public GameObject HatInteractive, CrossInteractive, CrossMapExtra, taks;
    public GameObject HatText, CrossText, BackgroundTexts;
    public GameObject ActionButtons;  
    string objName;
    bool isTalking, IntObOn, OnNow, MusicOff; 
    public static string currentTxt;
    Vector3 HatPos, CrossPos;


    void Start()
    {
      HatPos = HatInteractive.transform.localScale;
      CrossPos = CrossInteractive.transform.localScale;
    }

    void Update()
    {
    if(MarkerStates.activeRedSea == true){  
        MarkerStates.rsactice = true;
        MarkerStates.currentScreen = "RedBtn";
        if(IntObOn == false && !HatInteractive.activeSelf && !CrossInteractive.activeSelf && !taks.activeSelf){
            HatInteractive.SetActive(true); 
            CrossInteractive.SetActive(true);
            CrossMapExtra.SetActive(false);
            taks.SetActive(true);
            
        }

        if(MusicOff == true){
            FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
            MusicOff = false;
        }

    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;
            switch (objName)
            {
                case "CrossTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "CrossTalk";
                switchInteractive("CrossTalk");
                RedSeaMInfo.CurrentMTxt = "CrossTalk";
                FindObjectOfType<RedSeaMInfo>().BookIcon();
                FindObjectOfType<GhanaSounds>().MuteSound("Sudan");
                Invoke("TalkModel",1);
                break;

                case "HatTalk": 
                IntObOn = true;
                AllFalse();
                currentTxt = "HatTalk";
                CrossInteractive.SetActive(false);
                CrossMapExtra.SetActive(false);
                switchInteractive("HatTalk");
                RedSeaMInfo.CurrentMTxt = "HatTalk";
                FindObjectOfType<RedSeaMInfo>().BookIcon();
                FindObjectOfType<GhanaSounds>().MuteSound("Sudan");
                Invoke("TalkModel",1);
                break;

                default: 
                break;

            }

        }
    }
    } 
    }
    public void RedSeaFalse(){
        AllFalse(); 
        IntercativeFalse();
        FindObjectOfType<GhanaSounds>().StopSound("Sudan");
        RedSeaMInfo.CurrentMTxt = "none";
        IntObOn = false;
       // OnNow = true;
    }

    public void closeInteractiveModel(){ 
        AllFalse();
        IntercativeFalse();
        ResetSize();
        stopTalking();
        RedSeaMInfo.CurrentMTxt = "none";
        MusicOff = true;
        IntObOn = false;
        FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
      //  OnNow = true;

        
    }

    void AllFalse(){ 
        BackgroundTexts.SetActive(false); 
        HatText.SetActive(false); 
        CrossText.SetActive(false); 
        ActionButtons.SetActive(false); 
        RSRScaleANDRotate.Isenabled = false;
        FindObjectOfType<RedSeaMInfo>().closemtext(); 
        ResetSize();
    }

    void IntercativeFalse(){
        CrossInteractive.SetActive(true); 
        HatInteractive.SetActive(true);
        CrossMapExtra.SetActive(false);
        taks.SetActive(true);
    }

    void switchInteractive(string WhichOne){
        RSRScaleANDRotate.Isenabled = true;
        isTalking = true;
        ActionButtons.SetActive(true); 
        BackgroundTexts.SetActive(true);
        taks.SetActive(false); 
        switch (WhichOne)
            {
                case "HatTalk": 
                HatText.SetActive(true); 
                HatInteractive.SetActive(true); 
                CrossInteractive.SetActive(false);
                CrossMapExtra.SetActive(false);
                CrossText.SetActive(false); 
                break;

                case "CrossTalk": 
                CrossText.SetActive(true); 
                CrossInteractive.SetActive(true);
                CrossMapExtra.SetActive(true);
                HatText.SetActive(false); 
                HatInteractive.SetActive(false); 
                break;

                default:
                break;
            }
    
    }
    public void TalkModel(){
    if(isTalking == true){
    switch(currentTxt)
        {
            case "CrossTalk":   
            startTalking("Approximately 1.3 million slaves were sent across the Sahara, the Red Sea and the Indian Ocean in the seventeenth and eighteenth centuries. The trans-saharan traffic was about 700,000 per century, which allows 7,000 per year, but which may well be too high. Ralph Austen has estimated the volume of this trade to the Islamic world - admittedly on very scanty evidence. The figures cited here, 20,000 for the Saharan trade between 650 and 1600 and 2,400,000 for the Red Sea and Indian Ocean trade between 800 and 1600, could be twice as many slaves as the number actually exported or considerably less than the total volume. The time span is so great and the supply area so extensive that the estimated figure (7,220,000) is a rough approximation indeed; a range of 3.5 to 10 million is more accurate.  ");
            isTalking = false;
            break;

            case "HatTalk":   
            startTalking("Although slave exports came from a commercial frontier that stretched thousands of kilo-metres along the southern edge of the Sahara, the Red Sea, and the East African coast, there were relatively few export points, and consequently the impact of the trade was more concentrated than the distance might suggest. The Red Sea ports served the Ethiopian highlands and the Nile valley and included Suakin, Massawa, Tajura, and Zeila. The East African towns comprised one route that stretched northward along the coast. In Ethiopia, a Muslim holy war directed from the sultanate of Adal, temporarily overran the christian Kingdom, so that from the 1520s through the 1540s thousands of slaves were exported across the Red sea. The 3D model you see, it’s an Ethiopian ceremonial shield. ");
            isTalking = false;
            break;

            default:
            break;
        }
    }else{
        stopTalking();
        isTalking = true;
    }

 }

 void ResetSize(){
        CrossInteractive.transform.localScale = CrossPos;
        HatInteractive.transform.localScale  = HatPos;
    }


    //speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }


  public void playSondNow(){
    FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
  }


}
