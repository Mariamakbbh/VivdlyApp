using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavManager : MonoBehaviour
{
    public GameObject Warning;
    // int StartWidth;
    // int StartHight;
    // int TargetWidth;
    // int TargetHight;

    // private void Awake() {
    //     Screen.SetResolution()
    // }
    // Start is called before the first frame update
    void Start()
    {
        if(Wait.isStart == true){
            Warning.SetActive(true);
            Wait.isStart = false;
            Resources.UnloadUnusedAssets();
      System.GC.Collect();
        }
        
    }

   public void WarningOff(){
        Warning.SetActive(false);
        Destroy(Warning);
    }

    public void GoToAncientAfrica(){
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        World.IsOn = true;
        SceneManager.LoadSceneAsync(2);
    }

    public void GoToSlavery(){
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        World.IsOn = false;
        SceneManager.LoadSceneAsync(3);
    }
    public void GoToColonial(){
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        World.IsOn = false;
        SceneManager.LoadSceneAsync(4);
    }
    public void GoToModernAfrica(){
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        World.IsOn = false;
        SceneManager.LoadSceneAsync(5);
    }
}
