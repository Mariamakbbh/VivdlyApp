using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using Vuforia;

public class World : MonoBehaviour
{
    public static bool IsOn;

    public GameObject wordCanvas;
    public GameObject worldObj;
    public GameObject skipWorld;

    //sign
    public GameObject UISign;

    //signs on map
    public GameObject ghanaObj;
    public GameObject maliObj;
    public GameObject song;
    public GameObject songh;

   public static bool markerEndWorld = false; //ghana
   public static bool markerEndWorldMali = false; //mali
   public static bool markerEndWorldSonghai = false; //sonhai

    //audio
    AudioSource worldSound;


    private void Start() {
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
        worldSound = GetComponent<AudioSource>(); 
        VoiceController.worldStop = false;
        IsOn = true;
        FindObjectOfType<foundMarker>().Notfound();
        print("play sound");
        Invoke("VoiceCanvas",1);
        
    }


    public void VoiceCanvas() {
    if(IsOn){
        worldSound.Play();
        print("World talking...");
        startTalking("Long before the Europeans arrived in the 16th and 17th centuries, sub-Saharan West Africa saw the emergence of a series of African empires that lasted for centuries and stretched over vast swathes of the continent. They were known as the Ghana, Mali and Songhai Empires.  For more than a thousand years, from A.D. 500 to 1700, the medieval kingdoms of Ghana, Mali, and Songhay grew rich on the gold, salt, and slave trade that stretched across Africa. Scraping away hundreds of years of ignorance, prejudice, and mythology, we’ll reveal the glory of these forgotten empires. ");
        IsOn = false;
        VoiceController.worldStop = true;
    }
    else{
        print("ISON is false & World Not talking");          
        Invoke("endWorld", 4);
    }    
    }


 void endWorld(){
    print("endWorld: deactivate world");
    worldSound.Pause();
    wordCanvas.SetActive(false);
    worldObj.SetActive(false);
    ghanaObj.SetActive(false);
    maliObj.SetActive(false);
    song.SetActive(false);
    songh.SetActive(false);
    UISign.SetActive(false);
    skipWorld.SetActive(false);
    markerEndWorldMali = true; //mali
    markerEndWorldSonghai = true; //sonhai
    stopTalking();
    Invoke("end",1); 
}

 void end(){
    TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
    FindObjectOfType<foundMarker>().notfoundCanvas();
    print("Vuforia Tracking start!");
}

public void enableSignsOnMap(){
    ghanaObj.SetActive(true);
    maliObj.SetActive(true);
    song.SetActive(true);
    songh.SetActive(true);
}

public void enableSigns(){
    UISign.SetActive(true);
}

//spoke
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  }

}
