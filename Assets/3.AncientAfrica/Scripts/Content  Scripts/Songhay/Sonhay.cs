using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sonhay : MonoBehaviour
{
    //public VideoPlayer videoPlayer;
    public static bool isSonhayVideoPlaying = false;
    public static bool isSonhayVideo = false;
    string objName;
   // public GameObject Videoo;
    public GameObject ContentAccuracy;
    public GameObject ActionButtons;
    

    void Update(){
    if(isSonhayVideo == true){
        if(foundMarker.SonhIntro == 1){ 
            ContentAccuracy.SetActive(true);
            rotateObject.Isenabled = true;
            FindObjectOfType<VoiceController>().startSpeacking("Welcome to ancient Songhai. The following visualisation is an approximate representation based upon historical evidence.");
            Invoke("turnOff", 5);
            foundMarker.SonhIntro += 2;
        }
                SonactionButtonsON();
                rotateObject.objectToRotate = "Songhai";
                ScaleInOut.objectToScale = "Songhai";
               
         
        }else if(isSonhayVideo == false){

        setAllFalse();
        SonactionButtonsOFF();
          
            }
        }


    public void turnOff(){
        ContentAccuracy.SetActive(false);
    }
    void setAllFalse(){
        //rotateObject.rotateStatus = false;
       
  }   
  void SonactionButtonsON(){
      ActionButtons.SetActive(true); 
    }  

  void SonactionButtonsOFF(){
      ActionButtons.SetActive(false); 
      FindObjectOfType<ScaleInOut>().ResertSizeMSon();
  }

    void stopSonMusic(){
    FindObjectOfType<GhanaSounds>().StopSound("SongayMusic");
    }

    void playSonMusic(){
    FindObjectOfType<GhanaSounds>().PlaySound("SongayMusic");
    }




//spoke
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  }

}
