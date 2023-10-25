using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

//[RequireComponent(typeof(Collider))]
public class foundMarker : MonoBehaviour
{
    public GameObject NotFoundMarkerUI;
    public GameObject GhanaBackk, PrayerObject, starCanvas, WorldGameOb;

    public static int GhanaIntro = 0;
    public static int MaliIntro = 0;
    public static int SonhIntro = 0;
    int talkfirsttime = 0; 

    public void Notfound(){
        NotFoundMarkerUI.SetActive(false);
    }

public void notfoundCanvas() {
     if(World.IsOn == false){
        StopTalkingAnim();
        talkfirsttime++; 
        Ghana.foundMarkerr = false;
        FindObjectOfType<rotateObject>().NotRotateObject();
        FindObjectOfType<GhanaSounds>().StopSound("MaliMusic");
        NotFoundMarkerUI.SetActive(true);
        PrayerObject.SetActive(false);
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
        if(talkfirsttime == 3){
        Destroy(starCanvas);
        Destroy(WorldGameOb);
        }
        if(talkfirsttime <= 2 ){
            Invoke("canvasTalk",2);
        }  
        //rotateObject.Isenabled = false;
        if( GhanaIntro >= 1){
        FindObjectOfType<Ghana>().turnTalkCanvasOff();
        print("Turn Intro Off");
        }else if(MaliIntro >= 1){
        FindObjectOfType<Mali>().turnOff();
        } else if(SonhIntro >= 1){
        FindObjectOfType<Sonhay>().turnOff();
        }
    }
}
    public void canvasTalk(){
    startTalking("Please point your camera to the marker image, so that your device can recognise this, enabling you to start your AR experience.  If you have not downloaded and printed the marker images. Please navigate to the settings (positioned in the top right corner of your screen) and press the help / instructions icon so that you can access the download button from there.");
    }

   public void foundCanvas() {
    StopTalkingAnim(); 
    NotFoundMarkerUI.SetActive(false);
    FindObjectOfType<foundMarker>().GhanaBack(true);
    print("Canvas found, talking stop...");
    Invoke("CanvasGhana",1);           
    }

    public void CanvasGhana() {
    GhanaIntro++;
    Ghana.foundMarkerr = true; 
    PrayerObject.SetActive(true);
    FindObjectOfType<GhanaSounds>().PlaySound("Drums"); //play drums 
    }  

    //Mali

    public void foundMaliCanvas() {
    print("MaliCanvas found, talking stop...");
    StopTalkingAnim();
    FindObjectOfType<Mali>().closeText();
    NotFoundMarkerUI.SetActive(false);
    Invoke("CanvasMali",1);              
    }

    public void CanvasMali() {
    MaliIntro++;
    World.markerEndWorld = false;
    Mali.maliFound = true;
    FindObjectOfType<GhanaSounds>().PlaySound("MaliMusic");
    
    }

public void notfoundMaliCanvas() {
    if(World.markerEndWorldMali == true){
     World.markerEndWorld = true; 
     Mali.maliFound = false;
     FindObjectOfType<GhanaSounds>().StopSound("MaliMusic");
       notfoundCanvas();
    }
}

    //Songhai

public void foundSonCanvas() {
        print("SonCanvas found, talking stop...");
        StopTalkingAnim();
        NotFoundMarkerUI.SetActive(false);
        Invoke("CanvasSonh",1);
               
}

public void CanvasSonh() {
    SonhIntro++;
    World.markerEndWorld = false;
    Sonhay.isSonhayVideo = true; 
    FindObjectOfType<GhanaSounds>().PlaySound("SongayMusic");
        
}

public void notfoundSonCanvas() {
    if(World.markerEndWorldSonghai == true){
     World.markerEndWorld = true; 
     Sonhay.isSonhayVideo = false;  
     FindObjectOfType<GhanaSounds>().StopSound("SongayMusic");
     FindObjectOfType<GhanaSounds>().StopSound("MaliMusic");
       notfoundCanvas();
    }
}

public void StopTalkingAnim() {
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
}

public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

//deactivate ghana bacground
public void GhanaBack(bool state) {
    GhanaBackk.SetActive(state);
}


}

 