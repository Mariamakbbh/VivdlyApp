using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CommonEvents : MonoBehaviour
{
   
     public void GoToHome(){
        StopSpeack();
        World.IsOn = false;
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        SceneManager.LoadSceneAsync(1);
    }
    public void GoToAncientAfrica(){
        StopSpeack();
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        World.IsOn = true;
        foundMarker.GhanaIntro = 0;
        foundMarker.MaliIntro = 0;
        foundMarker.SonhIntro = 0;
        SceneManager.LoadSceneAsync(2);
    }

    public void GoToSlavery(){
        StopSpeack();
        World.IsOn = false;
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        SceneManager.LoadSceneAsync(3); //fresh memory before load new screen // destroy scene 
    }
    public void GoToColonial(){
        StopSpeack();
        World.IsOn = false;
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        SceneManager.LoadSceneAsync(4);
    }
    public void GoToModernAfrica(){
        StopSpeack();
        World.IsOn = false;
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        SceneManager.LoadSceneAsync(5);
    }

    void StopSpeack(){
        FindObjectOfType<VoiceController>().StopSpeacking();
    
    }

}
