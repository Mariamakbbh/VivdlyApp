using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerStates : MonoBehaviour
{
    public GameObject NotFoundMarkerUI, ActUnavailable;

    public GameObject SubSaharan, Indian, RedSea, Atlantic;
    public static bool activeSahara, activeIO, activeRedSea, activeAT;
    public static bool sahaactive, ioactive, rsactice, atactive;
     int firstTimeNotFound;
    public static bool IntroSahara;
    public static bool destroyitemsnow;
    int introSaha = 1;
    bool firsttimenotfoundoff =false;
    bool mustate = false;
    int IOfirst, RSfist, Atfirst;
    public static string currentScreen;

public void CNotFound(){
  NotFoundMarkerUI.SetActive(false);
  destroyitemsnow = true;
}

public void NotFound(){
  NotFoundMarkerUI.SetActive(true);
  ActUnavailable.SetActive(true);
}

//START canvas not found
    public void notfoundCanvas() {
      if(btnsPos.IntroDone == true){
        ActUnavailable.SetActive(true);
        IntroSahara = false; 
        firstTimeNotFound++;  
        NotFoundMarkerUI.SetActive(true);
        stopTalking();
        if(firstTimeNotFound >= 1){
        taksFromScreen();
        }
        mustate = false;
        activeSahara = false;
        activeIO = false;
         activeRedSea = false;
         activeAT = false; 
      }
    }  

    public void taksFromScreen(){
      if(sahaactive == true){
        sahaactive = false;
        FindObjectOfType<saharaScene>().MarkerToOperate();
      }else if(ioactive == true){
        ioactive = false;
        FindObjectOfType<IO>().indianOceanFalse();
      }else if(rsactice == true){
        rsactice = false;
        FindObjectOfType<RedSea>().RedSeaFalse();
      }else if(atactive == true){ 
        atactive = false;
        FindObjectOfType<Atlantic>().AtlanticFalse();
      }
      if(firstTimeNotFound <= 1){
        Invoke("canvas",2);
        } 
    }

void canvas(){
      ActUnavailable.SetActive(true);
      startTalking("Please point your camera to the marker image, so that your device can recognise this, enabling you to start your AR experience.  If you have not downloaded and printed the marker images. Please navigate to the settings (positioned in the top right corner of your screen) and press the help / instructions icon so that you can access the download button from there."); 
 }
//END canvas not found

//START canvas found
public void destroyAt(){
  Destroy(Atlantic);
  Destroy(Indian);
  Destroy(RedSea);
  IntroSahara = false;
}

public void destroySaha(){
  Destroy(SubSaharan);
  Destroy(Indian);
  Destroy(RedSea);
  destroyitemsnow = false;
}

    public void foundCanvas() {
    ActUnavailable.SetActive(true);
    stopTalking(); 
    mustate = true;
    firsttimenotfoundoff = true;
    NotFoundMarkerUI.SetActive(false); 
    if(introSaha <= 1){
    IntroSahara = true;
    introSaha++;
    }
    IOfirst++;
    RSfist++;
    Atfirst++;
    Invoke("CurrentBtn",2);
    }

    public void CurrentBtn(){
      switch (currentScreen)
    {
      case "sahaBtn":
      if(btnsPos.IntroDone == false){ 
      Indian.SetActive(false);  
      activeIO = false;
      RedSea.SetActive(false);  
      activeRedSea = false;
      Atlantic.SetActive(false); 
      activeAT = false;
      }
      Destroy(Atlantic);
      Destroy(Indian);
      Destroy(RedSea);
      SubSaharan.SetActive(true);  
      activeSahara = true;
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
      break;

      case "IndBtn":
      if(btnsPos.IntroDone == false){ 
        SubSaharan.SetActive(false);
      introSaha = 0;
      activeSahara = false;  
      RedSea.SetActive(false); 
      activeRedSea = false; 
      Atlantic.SetActive(false); 
      activeAT = false;
      }
      Indian.SetActive(true);
      activeIO = true; 
      if(activeIO == true && mustate == true){
        FindObjectOfType<IO>().playSpundNow();
        Destroy(Atlantic);
        Destroy(SubSaharan);
        Destroy(RedSea);
      }
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
      break;

      case "RedBtn":
      if(btnsPos.IntroDone == false){ 
        SubSaharan.SetActive(false);
      introSaha = 0;
      activeSahara = false;  
      Indian.SetActive(false); 
      activeIO = false; 
      Atlantic.SetActive(false); 
      activeAT = false;
      }
      RedSea.SetActive(true);  
      activeRedSea = true;
      if(activeRedSea = true && mustate == true){
        FindObjectOfType<RedSea>().playSondNow();  
        Destroy(Atlantic);
        Destroy(SubSaharan);
        Destroy(Indian);
      }
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
      break;

      case "atlan":
      if(btnsPos.IntroDone == false){ 
        SubSaharan.SetActive(false);
      introSaha = 0;
      activeSahara = false;  
      Indian.SetActive(false);  
      activeIO = false;
      RedSea.SetActive(false);
      activeRedSea = false;  
      }
      Atlantic.SetActive(true); 
      activeAT = true;
      if(activeAT = true && mustate == true){ 
      // Invoke("playsoundsnowp",2);  
       FindObjectOfType<Atlantic>().playSondNow(); 
       Destroy(SubSaharan);
       Destroy(Indian);
       Destroy(RedSea);
        
      }
      
      Resources.UnloadUnusedAssets();
      System.GC.Collect();
      break;

      default:
      break;
    }

    }

// public void playsoundsnowp(){
    
// }


//speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }
}
