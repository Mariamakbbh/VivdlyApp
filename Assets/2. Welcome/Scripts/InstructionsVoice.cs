using TextSpeech;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsVoice : MonoBehaviour
{
    const string LANG_CODE = "en-US";

    [SerializeField]
    Text uiTxt;

    private void Start() {
        setUp(LANG_CODE);

        // #if UNITY_ANDROID

        

        // #endif

        TextToSpeech.instance.onStartCallBack = OnSpeackStart;
        TextToSpeech.instance.onDoneCallback = OnSpeackStop;

    }

    // void CheckPermission()

    #region Text to Speech

    public void startSpeacking(string message){
        TextToSpeech.instance.StartSpeak(message);
    }

    public void StopSpeacking(){
        TextToSpeech.instance.StopSpeak();
    }

    //below perferct for an animation
    void OnSpeackStart(){
    }

    void OnSpeackStop(){
    }

    #endregion 

    void setUp(string code){
        TextToSpeech.instance.Setting(code, 1, 1);

    }
}
