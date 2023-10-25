using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonialMarker : MonoBehaviour
{
    public GameObject NotFoundMarkerUI, accuracyNow;
    public GameObject Buttons;

    public static bool mustate;
    int firstTimeNotFound;

public void ButtonsStatus(bool stat){
    Buttons.SetActive(stat);
}

//START canvas not found
    public void notfoundCanvas() {
        stopTalking(); 
        ButtonsStatus(false);
        firstTimeNotFound++;
        mustate = false;
        taksFromScreen();
        NotFoundMarkerUI.SetActive(true);
        if(firstTimeNotFound <= 1){
        Invoke("canvas",1);
        }   
        if(firstTimeNotFound == 2){
        contentAccuracyClose();
        }  
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
    }  

    void canvas(){
      startTalking("Please point your camera to the marker image, so that your device can recognise this, enabling you to start your AR experience.  If you have not downloaded and printed the marker images. Please navigate to the settings (positioned in the top right corner of your screen) and press the help / instructions icon so that you can access the download button from there."); 
    }

    void taksFromScreen(){
      ButtonsStatus(false);
      FindObjectOfType<Coloni>().allOff();
      FindObjectOfType<Coloni>().clsbtn();
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
    }
//END canvas not found



//START canvas found
    public void foundCanvas() {
    stopTalking(); 
    ButtonsStatus(true);
    mustate = true;
    NotFoundMarkerUI.SetActive(false); 
    if(firstTimeNotFound <= 1){
      Invoke("canvasFound",1);
    }
    }
    void canvasFound(){
      accuracyNow.SetActive(true);
      startTalking("The following visualisation is an approximate representation based upon historical evidence. Welcome to the infamous colonial period. Please click one of the side buttons to start your AR experience."); 
    Invoke("contentAccuracyClose",8);
    }

    void contentAccuracyClose(){
      Destroy(accuracyNow);
    }
//END canvas found


//speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }
}
