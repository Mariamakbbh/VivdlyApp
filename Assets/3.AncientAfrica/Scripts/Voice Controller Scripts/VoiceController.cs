using TextSpeech;
using UnityEngine;
using UnityEngine.UI;

public class VoiceController : MonoBehaviour
{
    const string LANG_CODE = "en-UK";

    
    public GameObject human;
   public Animator anim;
   public static bool worldStop;
   public static bool stopSpeackingSlavery,stopSpeacking, stopAtlanticSpeacking;
   public static bool speackstate;
    // public float pitch;
    // public float rate;
    

    private void Start() {
        setUp(LANG_CODE);
        anim = human.GetComponent<Animator>();
        
        // #if UNITY_ANDROID

        

        // #endif

        TextToSpeech.instance.onStartCallBack = OnSpeackStart;
        TextToSpeech.instance.onDoneCallback = OnSpeackStop;

    }

    // void CheckPermission()

    #region Text to Speech

    public void startSpeacking(string message){
        print("I'm speacking");
        TextToSpeech.instance.StartSpeak(message);
    }

    public void StopSpeacking(){
        print("STOP speacking");
        TextToSpeech.instance.StopSpeak();
        
    }

    //below perferct for an animation
    void OnSpeackStart(){
        print("Talking ANIM STARTED...!");
        anim.SetBool("talk",true);
        speackstate = true;
    }

    public void OnSpeackStop(){
        print("Talking ANIM STOPED...!");
        anim.SetBool("talk",false);
        speackstate = false;
        //ancient africa intro
        if(worldStop == true){
        FindObjectOfType<World>().VoiceCanvas();
        worldStop = false;
        }
        //slavery intro
        if (stopSpeackingSlavery == true){
            stopSpeackingSlavery = false;
           FindObjectOfType<btnsPos>().SkipIntro(); 
           
        }
        //slavery intro
        if (stopSpeacking == true){
           //skiparab
           stopSpeacking = false; 
           FindObjectOfType<btnsPos>().SkipArabIntro(); 
           
        }
        //slavery Atlantic intro
        if (stopAtlanticSpeacking == true){
           //skiparab
           stopAtlanticSpeacking = false; 
           FindObjectOfType<btnsPos>().SkipAtlanticIntro(); 
           
        }
       
    }

    #endregion 

    void setUp(string code){
        TextToSpeech.instance.Setting(code, 1, 1);

    }

    public void stopAnim(){
        anim.SetBool("talk",false);
    }
}
