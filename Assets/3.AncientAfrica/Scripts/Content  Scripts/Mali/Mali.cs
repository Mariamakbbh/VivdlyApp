using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Video;

public class Mali : MonoBehaviour
{
    //public VideoPlayer videoPlayer;
    public static bool maliFound = false;
    string objName;
    public GameObject ContentAccuracy;
    public GameObject BackgroundMaliTexts;
    public GameObject MansaText;
    public GameObject MusilmText; 
    public GameObject ActionButtons;
    string OurcurrentTxt;
    bool isTalking;

    void Update(){
    if(maliFound == true){
        if(foundMarker.MaliIntro == 1){ 
            print("MaliTalk Intro"); 
            ContentAccuracy.SetActive(true);
            FindObjectOfType<VoiceController>().startSpeacking("Welcome to ancient Mali. The following visualisation is an approximate representation based upon historical evidence. Press the red floating icons to start your experience");
        Invoke("turnOff", 5);
        foundMarker.MaliIntro += 2;
        }
        
    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;

            switch (objName)
            {
                case "MusaTalk":
                stopMaliMusic();
                //display text
                setAllFalse();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().MusaOn();
                rotateObject.Isenabled = true;
                //action buttons on
                MaliactionButtonsON();
                rotateObject.objectToRotate = "Musa";
                ScaleInOut.objectToScale = "Musa";
                MaliMoreInfo.currentTxt = "musa";
                BackgroundMaliTexts.SetActive(true);
                MansaText.SetActive(true);
                OurcurrentTxt = "MusaTalk";
                isTalking = true;
                Invoke("AssetTalk",2);
                //start model talking   
                break;

                case "MuslimTalk": 
                stopMaliMusic();
                //display text
                setAllFalse();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().MuslimOn();
                rotateObject.Isenabled = true;
                //action buttons on
                MaliactionButtonsON();
                rotateObject.objectToRotate = "Muslim";
                ScaleInOut.objectToScale = "Muslim";
                MaliMoreInfo.currentTxt = "muslim";
                BackgroundMaliTexts.SetActive(true);
                MusilmText.SetActive(true);
                //start model talking  
                OurcurrentTxt = "MuslimTalk";
                isTalking = true;
                Invoke("AssetTalk",2);
                 break;

                default:
                break;
            }
        }
    }
    }else{
        setAllFalse();
        MaliactionButtonsOFF();
    }
    }

      public void AssetTalk(){
        if(isTalking == true){
    switch(OurcurrentTxt)
        {
            case "MusaTalk":   
            startTalking("Mansa Musa (Musa I of Mali) was the ruler of the kingdom of Mali from 1312 C.E. to 1337 C.E. During his reign, Mali was one of the richest kingdoms of Africa, and Mansa Musa was among the richest individuals in the world. The ancient kingdom of Mali spread across parts of modern-day Mali, Senegal, the Gambia, Guinea, Niger, Nigeria, Chad, Mauritania, and Burkina Faso. Mansa Musa developed cities like Timbuktu and Gao into important cultural centers. He also brought architects from the Middle East and across Africa to design new buildings for his cities. Mansa Musa turned the kingdom of Mali into a sophisticated center of learning in the Islamic world. ");
            isTalking = false;
            break;

            case "MuslimTalk":   
            startTalking("When Mansa Musa went on a pilgrimage (hajj) to Mecca in 1324 C.E., his journey through Egypt caused quite a stir. The kingdom of Mali was relatively unknown outside of West Africa until this event. Arab writers from the time said that he travelled with an entourage of tens of thousands of people and dozens of camels, each carrying 136 kilograms (300 pounds) of gold. While in Cairo, Mansa Musa met with the Sultan of Egypt, and his caravan spent and gave away so much gold that the overall value of gold decreased in Egypt for the next 12 years. Stories of his fabulous wealth even reached Europe. The Catalan Atlas, created in 1375 C.E. by Spanish cartographers, shows West Africa dominated by a depiction of Mansa Musa sitting on a throne, holding a nugget of gold in one hand and a golden staff in the other. After the publication of this atlas, Mansa Musa became cemented in the global imagination as a figure of stupendous wealth.");
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



    void setAllFalse(){
        BackgroundMaliTexts.SetActive(false);
       // rotateObject.rotateStatus = false;
        MansaText.SetActive(false);
        MusilmText.SetActive(false);
  }   
  void MaliactionButtonsON(){
      ActionButtons.SetActive(true); 
    }  

  void MaliactionButtonsOFF(){
      ActionButtons.SetActive(false); 
      FindObjectOfType<ScaleInOut>().ResertSizeMali();
  }


    public void turnOff(){
    ContentAccuracy.SetActive(false);
    }

    void stopMaliMusic(){
    FindObjectOfType<GhanaSounds>().StopSound("MaliMusic");
    }

    void playMaliMusic(){
    FindObjectOfType<GhanaSounds>().PlaySound("MaliMusic");
    }

    public void closeText(){
       //rotateObject.rotateStatus = false;
       rotateObject.Isenabled = false;
       FindObjectOfType<ScaleInOut>().MaliOn();
       setAllFalse();
       MaliactionButtonsOFF();
       playMaliMusic();
       stopTalking();
    }


    //close current text if more text clicked
public void MusaMoreText(bool chang){
    BackgroundMaliTexts.SetActive(chang);
    MansaText.SetActive(chang);
}

public void MuslimMoreText(bool chang){
    BackgroundMaliTexts.SetActive(chang);
    MusilmText.SetActive(chang);
}


//spoke
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  }


}