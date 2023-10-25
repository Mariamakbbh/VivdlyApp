using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IO : MonoBehaviour
{
    public GameObject ShipInteractive, IndianOSlaveInteractive, taks;
    public GameObject ShipText, IndianOSlaveText, BackgroundTexts;
    public GameObject ActionButtons;  
    string objName;
    bool isTalking, IntObOn, MusicOff; 
    public static string currentTxt;
    Vector3 ShipPos, IndianOSlavePos;


    void Start()
    {
      ShipPos = ShipInteractive.transform.localScale;
      IndianOSlavePos = IndianOSlaveInteractive.transform.localScale;
    }

    void Update()
    {
    if(MarkerStates.activeIO == true){  
     MarkerStates.ioactive = true;
     MarkerStates.currentScreen = "IndBtn";
        if(IntObOn == false && !ShipInteractive.activeSelf && !IndianOSlaveInteractive.activeSelf && !taks.activeSelf){
            ShipInteractive.SetActive(true); 
            IndianOSlaveInteractive.SetActive(true);
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
                case "IndianSlaveTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "IndianSlaveTalk";
                switchInteractive("IndianSlaveTalk");
                IOMoreInfo.CurrentMTxt = "IndianSlaveTalk";
                FindObjectOfType<IOMoreInfo>().BookIcon();
                FindObjectOfType<GhanaSounds>().MuteSound("Sudan");
                Invoke("TalkModel",1);
                break;

                case "SlaveShipTalk": 
                IntObOn = true;
                AllFalse();
                currentTxt = "SlaveShipTalk";
                switchInteractive("SlaveShipTalk");
                IOMoreInfo.CurrentMTxt = "SlaveShipTalk";
                FindObjectOfType<IOMoreInfo>().BookIcon();
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
    public void indianOceanFalse(){
        AllFalse(); 
        IntercativeFalse();
        IOMoreInfo.CurrentMTxt = "none";
        FindObjectOfType<GhanaSounds>().StopSound("Sudan");
        IntObOn = false;
    }

    public void closeInteractiveModel(){
        AllFalse();
        IntercativeFalse();
        ResetSize();
        stopTalking();
        IOMoreInfo.CurrentMTxt = "none";
        MusicOff = true;
        IntObOn = false;
        FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
        
        
    }

    void AllFalse(){ 
        BackgroundTexts.SetActive(false); 
        ShipText.SetActive(false); 
        IndianOSlaveText.SetActive(false); 
        ActionButtons.SetActive(false); 
        IOScaleANDRotate.Isenabled = false;
        FindObjectOfType<IOMoreInfo>().closemtext();
        ResetSize();
    }

    void IntercativeFalse(){
        IndianOSlaveInteractive.SetActive(true); 
        ShipInteractive.SetActive(true);
        taks.SetActive(true);
    }

    void switchInteractive(string WhichOne){
        isTalking = true;
        IOScaleANDRotate.Isenabled = true;
        ActionButtons.SetActive(true); 
        BackgroundTexts.SetActive(true);
        taks.SetActive(false);
        switch (WhichOne)
            {
                case "SlaveShipTalk": 
                ShipText.SetActive(true); 
                ShipInteractive.SetActive(true); 
                IndianOSlaveText.SetActive(false); 
                IndianOSlaveInteractive.SetActive(false);
                break;

                case "IndianSlaveTalk": 
                IndianOSlaveText.SetActive(true); 
                IndianOSlaveInteractive.SetActive(true);
                ShipText.SetActive(false); 
                ShipInteractive.SetActive(false); 
                break;

                default:
                break;
            }
    
    }
    public void TalkModel(){
    if(isTalking == true){
    switch(currentTxt)
        {
            case "IndianSlaveTalk":   
            startTalking("From the eighth century onward, the Indian Ocean was the scene of extensive trade of sub-Saharan African slaves via sea routes controlled by Muslim Arab and Swahili traders. Several populations in present-day Pakistan and India are thought to be the descendants of such slaves, yet their history of admixture and natural selection remains largely undefined.");
            isTalking = false;
            break;

            case "SlaveShipTalk":   
            startTalking("The Indian Ocean region is a region of social and cultural diversity inhabited by peoples with numerous languages and religions. The region straddles three continents: Africa, Asia and Australia. The men, women and children from Africa who were transplanted to the region came into contact with socio-cultures much older than those encountered by African slaves who were taken to the Atlantic Ocean region.");
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
        IndianOSlaveInteractive.transform.localScale = ShipPos;
        ShipInteractive.transform.localScale  = IndianOSlavePos;
    }


    //speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }

  public void playSpundNow(){
    FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
  }


}
