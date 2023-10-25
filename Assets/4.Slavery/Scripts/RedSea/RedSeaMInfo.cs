using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSeaMInfo : MonoBehaviour
{
    public GameObject HatMText, CrossMText; //RED SEA
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
            //REDSEA
            case "HatTalk":
            stopTalking();
            HatMText.SetActive(true);
            CurrentMTxt = "HatTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "CrossTalk":
            stopTalking();
            CrossMText.SetActive(true);
            CurrentMTxt = "CrossTalk";
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
    //red sea
    HatMText.SetActive(false);
    CrossMText.SetActive(false);

    stopTalking();
    isTalking = false;
}

public void closemtext(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    //red sea
    HatMText.SetActive(false);
    CrossMText.SetActive(false);
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
            case "HatTalk":
            startTalking("When the trade is broken down according to the main routes, then East Africa accounted for a traffic in the order of 1,000 slaves per year in the period from about 800 no to 1600; the Red Sea ports probably handled something like 2,000 slaves per year in the same period; while the six main routes across the Sahara averaged from 3,000 to 8,000 per year. This suggests an average volume for each route of about 1,000 per annum. Six major routes crossed the desert: one went north from ancient Ghana to Morocco; a second stretched north from Timbuktu to Tuat in southern Algeria; a third passed from the Niger valley and the Hausa towns through the Air Massif to Ghat and Ghadames; a fourth travelled north from Lake Chad to Murzuk inLibya; a fifth reached north from Dar Fur in the eastern Sudan to the Nile val-ley at Assiout; and a sixth passed north from the confluence of the Blue and theWhite Nile to Egypt. Some of these routes were interconnected. The ones north from Timbuktu went to Morocco, Algeria, and Libya, while the Dar Fur-Egyptroute, known as the forty days' road, connected with the route north from the upper Nile valley. In total, therefore, there were only nine or ten outlets for the slave trade to the Muslim world.");
            isTalking = false;
            break;

            case "CrossTalk":
            startTalking("A figure of 100,000 for the Red sea, reflecting an annual average of 1,000 per year, is allowed for the seventeenth century, and 200,000 is assessed for the eighteenth-century. The figures are based on very limited data, but trade across the Red Sea did seem to increase in the eighteenth century. Data are most complete for Egypt in the last decades of the eighteenth century, when an estimated 3,000 to 6,000 slaves were imported each year, but other markets in North Africa also consumed slaves - when the Moroccan sultans wanted slave soldiers in the late seventeenth and early eigh-teenth centuries, they looked to sub-saharan African as one source of recruits. Furthermore, the demand for children, young females appears to have been steady throughout the two centuries. ");
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
    Application.OpenURL("https://www.jstor.org/stable/44947358?refreqid=excelsior%3A73d11f58524d2311f796c5a4e4bf1d44&seq=1");
    }
}

