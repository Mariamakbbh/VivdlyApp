using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class buttonActions : MonoBehaviour
{
    bool soundOff = false;
    public GameObject commingS;
    private void Update() {
        
        if(soundOff){
            stopallSounds();
        }else{
            soundOff = false;
        }
    }
    public GameObject HelpMenu;
   // public GameObject HelpMenuBack;

    void Start()
    {
        HelpMenu.SetActive(false);
        //HelpMenuBack.SetActive(false);
    }

         public void quitApply(){
         Application.Quit();
     }

     public void OpenMainHelp(){
         HelpMenu.SetActive(true);
        // HelpMenuBack.SetActive(true);
     }

     public void CloseMainHelp(){
         FindObjectOfType<VoiceController>().StopSpeacking();
         FindObjectOfType<InstructionsController>().InstuctionsOFF();
         HelpMenu.SetActive(false); 
     }

     public void stopAllSound(){
         if(soundOff == true){
             soundOff = false;
         }else{
             soundOff = true;
         }
         
     }

    void stopallSounds(){
    if(SceneManager.GetActiveScene().buildIndex == 2){ //anicent
      FindObjectOfType<GhanaSounds>().StopSound("MaliMusic");
      FindObjectOfType<GhanaSounds>().StopSound("Drums");
      FindObjectOfType<GhanaSounds>().StopSound("Kora");
      FindObjectOfType<GhanaSounds>().StopSound("SongayMusic");

    }else if(SceneManager.GetActiveScene().buildIndex == 3){ //slavery
      FindObjectOfType<GhanaSounds>().StopSound("Omou");
      FindObjectOfType<GhanaSounds>().StopSound("Sudan");
      FindObjectOfType<GhanaSounds>().StopSound("Sahara");
      FindObjectOfType<GhanaSounds>().StopSound("North");

        // }else if(SceneManager.GetActiveScene().buildIndex == 4){   //col
           
        // }else if(SceneManager.GetActiveScene().buildIndex == 5){  //modern A
         
    }
  }

  public void MarkerImagesLink(){
      Application.OpenURL("https://drive.google.com/drive/folders/1WqWCCiGMlTcvDESZWOOSH2jzfSA5STjo?usp=sharing");
  }

  public void CommingSoon(){
      commingS.SetActive(true);
      Invoke("closeit",3);
  }
  void closeit(){
      commingS.SetActive(false);
  }
}
