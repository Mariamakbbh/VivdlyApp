using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ghana : MonoBehaviour
{
    //script from 60%, 40% my personal modifications to better fit purpose

    //action objects 
    public GameObject ActionButtons;  

    //objects
    public static bool foundMarkerr;
    public GameObject BackgroundGhanaTexts;
    public GameObject SnakeText;
    public GameObject KoraText;
    public GameObject GriotText;
    public GameObject DingaText;
    public GameObject IslamText;
    public GameObject GoldText;
    public GameObject ContentAccuracy;
    public GameObject GhanaIntroTalk;
    string OurcurrentTxt;
    bool isTalking;
//    public GameObject m_ObjectCollider;

    string objName;

    void Start(){
        setAllFalse();
    }


 private void Update() {
    
    if(foundMarkerr == false){
        objName = "none";
        setAllFalse();
        stopAllMusic();
        actionButtonsOFF();
        FindObjectOfType<ScaleInOut>().InteractiveModels(false);
      //  print("Canvas gone: Ghana OFF");

    }else if(foundMarkerr == true){
       // stopTalking();
        if(foundMarker.GhanaIntro == 1){ 
            print("GhanaTalk Intro"); 
            ContentAccuracy.SetActive(true);
            Invoke("turnOff", 8);
            OurcurrentTxt = "IntroTalk";
            Invoke("AssetTalk",2);
            foundMarker.GhanaIntro += 2;
        }
        

    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;
            turnTalkCanvasOff();

            switch (objName)
            {
                case "KoraTalk":   
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().KoraOn();
                //action buttons on
                actionButtonsON();
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Kora";
                ScaleInOut.objectToScale = "Kora";
                GhanaMoreInfo.currentTxt = "kora";
                OurcurrentTxt = "KoraTalk";
                //play Kora
                FindObjectOfType<GhanaSounds>().PlaySound("Kora");
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                KoraText.SetActive(true);
                //start model talking   
                isTalking = true;
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                Invoke("AssetTalk",2);
                break;


                case "GriotTalk":
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().GriotOn();
                //action buttons on
                actionButtonsON();
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Griot";
                ScaleInOut.objectToScale = "Griot";
                GhanaMoreInfo.currentTxt = "griot";
                OurcurrentTxt = "GriotTalk";
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                GriotText.SetActive(true); 
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                //start model talking   
                isTalking = true;
                Invoke("AssetTalk",2);
                break;


                case "DingaTalk":
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().DingaOn();
                //action buttons on
                actionButtonsON();
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Dinga";
                ScaleInOut.objectToScale = "Dinga";
                GhanaMoreInfo.currentTxt = "dinga";
                OurcurrentTxt = "DingaTalk";
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                DingaText.SetActive(true);  
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                //start model talking   
                isTalking = true;
                Invoke("AssetTalk",2);
                break;


                case "SnakeTalk":
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().SnakeOn();
                //action buttons on
                actionButtonsON(); 
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Snake";
                ScaleInOut.objectToScale = "Snake";
                GhanaMoreInfo.currentTxt = "snake";
                OurcurrentTxt = "SnakeTalk";
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                SnakeText.SetActive(true); 
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                //start model talking  
                isTalking = true;
                Invoke("AssetTalk",2);
                break;


                case "GoldTalk":
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().GoldOn();
                //action buttons on
                actionButtonsON();  
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Gold"; 
                ScaleInOut.objectToScale = "Gold"; 
                GhanaMoreInfo.currentTxt = "gold";
                OurcurrentTxt = "GoldTalk";
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                GoldText.SetActive(true); 
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                //start model talking   
               isTalking = true;
               Invoke("AssetTalk",2);
               break;


                case "IslamTalk":
                stopAllMusic();
                //activate game object //bring to front
                FindObjectOfType<ScaleInOut>().IslamOn();
                //action buttons on
                actionButtonsON();
                rotateObject.Isenabled = true;
                rotateObject.objectToRotate = "Islam";
                ScaleInOut.objectToScale = "Islam";
                GhanaMoreInfo.currentTxt = "islam";
                OurcurrentTxt = "IslamTalk";
                //display text
                setAllFalse();
                BackgroundGhanaTexts.SetActive(true);
                IslamText.SetActive(true); 
                //deactivate sceen 
                FindObjectOfType<foundMarker>().GhanaBack(false);
                //start model talking   
                isTalking = true;
                Invoke("AssetTalk",2);
                break;

                default:
                break;

            }
        }
    }
    }

 }


  public void AssetTalk(){
        if(isTalking == true){
    switch(OurcurrentTxt)
        {
            case "KoraTalk":   
            startTalking("The Kora, is a harp built out of a large, dry gourd.");
            isTalking = false;
            break;

            case "GriotTalk":   
            startTalking("Many cultures depend on oral history instead of written books to remember the past. In West Africa, oral histories are studied and constantly retold by professional historians - musicians called Griots. Griots are singers whose ballads preserve the history of West Africa people. Many play the Kora, a harp built out of a large, dry gourd. Oral histories about the origin of the Empire of Ghana begin with a story of the Soninke ancestor, Dinga.");
            isTalking = false;
            break;

            case "DingaTalk":   
            startTalking("Nobody is sure when Ghana came into being. But some time at the beginning of the first millennium AD, it is thought that a number of clans of the Soninke people, (in modern Senegal) came together under a leader with semi-divine status, called Dinga Cisse. According to legend, Dinga Cisse came from the east. He travelled a very long time to reach the place that would become Ghana. When Dinga and his family finally settled, they established a group of communities, each headed by one of Dinga’s sons. These communities prospered and grew into the first kingdom of ancient Soninke, named Ghana. The Soninke people were divided into clans, look around to find out more about these clans.");
            isTalking = false;
            break;

            case "SnakeTalk":   
            startTalking("The wealth of Ghana is also explained mythically through the story of Bida, the black snake. The royal Sonnike people clung to their traditional beliefs, which included worship of Ouagadou-Bida, a great snake, which lived in a dark cave. This snake demanded an annual sacrifice in return for guaranteeing prosperity in the kingdom. Every year a virgin was offered up, until one year, the fiancé of the intended victim, (his name was Mamadou Sarolle) rescued her. Cheated of his sacrifice, Bida took his revenge on the region. A terrible drought took hold of Ghana and gold mining fell into decline. Archaeologists have found evidence that confirms elements of the story, showing that until the 12th century, sheep and cows, as well goats, were abundant in the region. But after that only the tougher, more drought-resistant goats were common.");
            isTalking = false;
            break;

            case "GoldTalk":   
            startTalking("What is clear, is that the Empire derived power and wealth from gold. And the introduction of the camel in the Trans-Saharan trade boosted the amount of goods that could be transported. Most of our knowledge of Ghana comes from Arab writers. Al-Hamdani, for example, describes Ghana as having the richest gold mines on earth. These were situated at Bambuk, on the upper Senegal River. The Soninke also sold slaves, salt and copper, in exchange for textiles, beads and finished goods. The capital of Kumbi Saleh became the focus of all trade, with a systematic form of taxation. Later Audaghust was another commercial centre.");
            isTalking = false;
            break;

            case "IslamTalk":   
            startTalking("Inevitably traders brought Islam with them. Initially, the Islamic community at Kumbi Saleh (Capital City of Ancient Ghana) remained a separate community some distance away from the king's palace. It had its own mosques and schools. But, the king retained his traditional beliefs. He drew on the book-keeping and literary skills of Muslim scholars to help run the administration of the territory. The state of Takrur to the west had already adopted Islam as its official religion and evolved ever closer trading ties with North Africa.");
            isTalking = false;
            break;

            case "IntroTalk":
            startTalking("Welcome to ancient Ghana. The following visualisation is an approximate representation based upon historical evidence. Now, Despite its name, the old Empire of Ghana is not geographically, ethnically, or in any other way, related to modern Ghana. It lies about four hundred miles north-west of modern Ghana. Ancient Ghana encompassed what is now modern Northern Senegal and Southern Mauritania. The empire of Ghana, also known as Wagadou, was a wealthy trading empire in West Africa located south of the Sahara Desert. Made up of a federation of the Soninke people, its richest historical record spans from about 750 until 1076 CE, due to the writings of Arab travellers and geographers from that period. Press the red floating icons to start your experience");
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
        BackgroundGhanaTexts.SetActive(false);
        //rotateObject.rotateStatus = false;
        SnakeText.SetActive(false);
        KoraText.SetActive(false);
        GriotText.SetActive(false);
        DingaText.SetActive(false);
        IslamText.SetActive(false);
        GoldText.SetActive(false);
  }   
  public void actionButtonsON(){
         ActionButtons.SetActive(true);     
    }  

  public void actionButtonsOFF(){
      ActionButtons.SetActive(false);
      FindObjectOfType<foundMarker>().GhanaBack(true);
  }  
    
    void stopDrums(){
        FindObjectOfType<GhanaSounds>().StopSound("Drums");
  } 
  
  void stopAllMusic(){
        FindObjectOfType<GhanaSounds>().StopSound("Drums");
        FindObjectOfType<GhanaSounds>().StopSound("Kora");
  } 

  void playDrums(){
        FindObjectOfType<GhanaSounds>().PlaySound("Drums");
  }
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }  

  public void stopTalking(){
       //stop anim + voice
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  } 
  public void closeText(){
       //rotateObject.rotateStatus = false;
       FindObjectOfType<ScaleInOut>().InteractiveModels(false);
       FindObjectOfType<foundMarker>().GhanaBack(true);
       rotateObject.Isenabled = false;
       stopAllMusic();
       setAllFalse();
       actionButtonsOFF();
       playDrums();
       stopTalking();
    }
    public void turnOff(){
        ContentAccuracy.SetActive(false);
        GhanaIntroTalk.SetActive(true);
    } 
    public void turnTalkCanvasOff(){
        stopTalking();
        GhanaIntroTalk.SetActive(false);
        ContentAccuracy.SetActive(false);
        
    }  

//close current text if more text clicked
public void SnakeMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    SnakeText.SetActive(chang);
}

public void KoraMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    KoraText.SetActive(chang);
}

public void GriotMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    GriotText.SetActive(chang);
}

public void DingaMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    DingaText.SetActive(chang);
}

public void IslamMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    IslamText.SetActive(chang);
}

public void GoldMoreText(bool chang){
    BackgroundGhanaTexts.SetActive(chang);
    GoldText.SetActive(chang);
}










}

