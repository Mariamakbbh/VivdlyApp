using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOMoreInfo : MonoBehaviour
{
    public GameObject ShipMText, IndianOMSlaveText;
    public GameObject BackgroundTexts, backblurr, OnlineExplore, book;
    public static string CurrentMTxt;
    bool isTalking;

    public void BookIcon(){
        if(CurrentMTxt == "none"){
        book.SetActive(false);
        return;
    }else{
        book.SetActive(true);
    }
    }

    //open additional info
public void BookMoreText(){
    if(CurrentMTxt == "none"){
        book.SetActive(false);
        return;
    }else{
    BackgroundTexts.SetActive(true);
    backblurr.SetActive(true);
    OnlineExplore.SetActive(true);
    book.SetActive(true);
    print("current text in open more infor is" + CurrentMTxt);
    
    switch(CurrentMTxt)
        {
            case "SlaveShipTalk": 
            stopTalking();
            ShipMText.SetActive(true);
            CurrentMTxt = "SlaveShipTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "IndianSlaveTalk":
            stopTalking();
            IndianOMSlaveText.SetActive(true);
            CurrentMTxt = "IndianSlaveTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            default:
            break;
        }
    }
}


//close all
public void CloseMoreText(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    IndianOMSlaveText.SetActive(false);
    ShipMText.SetActive(false);
    stopTalking();
    isTalking = false;
}

public void closemtext(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    IndianOMSlaveText.SetActive(false);
    ShipMText.SetActive(false);
    isTalking = false;

}


//spoke
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }



//talking

public void OpenTalk(){
    if(isTalking == true){
    switch(CurrentMTxt)
        {
            case "SlaveShipTalk":   
            startTalking("Slavery was widespread in the ancient world, from the Mediterranean to China. Within the Indian Ocean region, Africa and South East Asia were the major sources of slave supply, but slaves from the latter area remained within the area itself. By the 4th century, the entire African region from Ethiopia to Madagascar had become a major source of slaves for markets from Europe to China. Until the 8th century, the traffic in slaves appears to have been both small and intermittent, but it later flourished at the peak of the Arab empire, between the 9th and 11th centuries. In due course a regular network of slave routes developed across the Indian Ocean, from Madagascar to the Moluccas, with Africa and the Indonesian Archipelago as the main suppliers. East Africa, Madagascar, the Sudan and Ethiopia supplied slaves, via the Red and Arabian Seas, to many countries in the East, including Egypt, Arabia, Mesopotamia, Persia, and India. The slave trade subsequently decreased, as a result of the decline of the Arab Empire, but it received a fillip in the early 16th century on account of fighting in Ethiopia and the Hom of Africa, where many slaves were captured and taken to India, and in particular to Gujarat, in the north-west of the sub-continent.");
            isTalking = false;
            break;


            case "IndianSlaveTalk":
            startTalking("In India, African slaves were considered luxury and prestige commodities. An owner's social status in India, as indeed in Ethiopia, was measured by the number of his slaves, who constituted an important part of his retinue and an ostentatious way of displaying wealth and power. African slaves undertook tasks which Indians could not perform on account of caste restrictions, or tasks which they would simply not perfor1n, or which the British deemed unsuitable. In the princely states, which were free of British rule, African slaves served as domestics, concubines, eunuchs, water carriers, barbers, personal guards, stable-boys etc. From the 8th to the 19th centuries, about four million people were captured from the shores of eastern Africa by Arab Muslim and Swahili traders. It has been suggested that slaves transported before the 16th century originated from the Horn of Africa, Nilotic or Afro-Asiatic speakers from present-day Ethiopia, whereas most Africans enslaved from the 18th century onward were Zanj, Bantu speakers of southeastern Africa. Indeed, the Omani Empire progressively imposed their domination on the Swahili coast and Zanzibar in this time period, leading to an intensified slave trade from these regions. However, direct evidence of the provenance of the African slaves embarked for the Indian Ocean trade remains lacking.");
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

//additional resources WEB 
public void ExternalSiteMoreText(){

            Application.OpenURL("https://www.youtube.com/watch?v=5OdIqeWkhHU");
    }


    //additional resources BOOK 
public void ExternalBookMoreText(){
    Application.OpenURL("https://www.worldcat.org/title/african-diaspora-in-the-indian-ocean/oclc/155485258 ");
    }
}

