using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonghayMoreInfo : MonoBehaviour
{
    public GameObject BackgroundSonTexts;
    public GameObject SonghMoreText;
    public GameObject backblurr;
    bool isTalking;
    public static string currentTxt;

void Start(){
    isTalking = false;
    CloseMoreText();
}

 //open additional info
  public void BookMoreText(){
    FindObjectOfType<GhanaSounds>().StopSound("SongayMusic");
    Animator[] animatorsInTheScene = FindObjectsOfType(typeof(Animator)) as Animator[];
                
            foreach (Animator animatorItem in animatorsInTheScene)
            {
                animatorItem.SetBool("IsIdle", true);
            }
    BackgroundSonTexts.SetActive(true);
    backblurr.SetActive(true);
    stopTalking();
    SonghMoreText.SetActive(true);
    isTalking = true;

    }

 //closeText
    public void CloseInText(){
        Animator[] animatorsInTheScene = FindObjectsOfType(typeof(Animator)) as Animator[];        
        foreach (Animator animatorItem in animatorsInTheScene)
        {
            animatorItem.SetBool("IsIdle", false);
        }
        FindObjectOfType<GhanaSounds>().PlaySound("SongayMusic");
        FindObjectOfType<ScaleInOut>().ResertSizeMSon();
        CloseMoreText();      
    }



//close all
public void CloseMoreText(){
    BackgroundSonTexts.SetActive(false);
    backblurr.SetActive(false);
    SonghMoreText.SetActive(false);
    isTalking = false;
    FindObjectOfType<ScaleInOut>().ResertSizeMSon();
    stopTalking();
}



//spoke
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  }



//talking

public void OpenTalk(){
    if(isTalking == true){

            startTalking("Songhay,  the  third  of  the  medieval  West  African  empires,  began  as a  trading  town  called  Gao  on  the  eastern  side  of  the  Niger  Bend.  Gao (which  the  Arab  geographers  called  Gawgaw)  had  its  beginnings  about the  same  time  that  Ghana  was  getting  started,  some  time  after  500.  Gao eventually  developed  into  a  kingdom  controlled  by  the  Songhay  people. These  people  have  some  cultural  similarities  to  the  Mande  peoples  of Ghana and Mali, but they speak a different language. In  the  early  14th  century,  Gao  was  conquered  by  Mali  and  added  to the  Mali  Empire.  About  30  years  later,  the  Mali  Empire’s  influence  had begun to decline. By the 1430s, Gao had regained its independence. In  the  second  half  of  the  15th  century,  a  great  ruler  named  Sii  Ali Beeri  (sometimes  spelled  Sunni  Ali)  came  to  power  in  Gao.  He  conquered  many  neighboring  chiefs  and  kings,  took  over  their  territories, and  established  the  Songhay  Empire.  The  Songhay  rulers  controlled  a vast  empire  in  the  Western  Sudan.  Their  lands  included  eastern  portions of the old empires of Ghana and Mali. Songhay was conquered by an army from Morocco in 1591.");
            isTalking = false;
    
    }else{
        stopTalking();
        isTalking = true;
    }

}

//additional resources WEB 
public void ExternalSiteMoreText(){

            Application.OpenURL("https://www.youtube.com/watch?v=hYynGlqkLb8&t=154s");

    }








}
