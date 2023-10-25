using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;
using UnityEngine.UI;

public class btnsPos : MonoBehaviour
{
    public GameObject sahaBack, indBack, redBack, atlBack, initMenu, introSlav, contentAccuracy, ActUnavailable;
    public Text screenName;
    public GameObject ArabEarth, ArabIntroBack;
    public GameObject AtlanticSea, AtlanticIntroBack;
    int count = 0;
    int Wcount = 0;
    public static bool IntroDone, SlaveryIntroDone, nowdoit;
    public static string currentScreen;

private void Awake() {
    Invoke("postStart",1); 
} 

    private void Start() {
        IntroDone = false;
        initMenu.SetActive(false);
        introSlav.SetActive(false);
        ArabIntroBack.SetActive(false);
        ArabEarth.SetActive(false);
        AtlanticSea.SetActive(false);
        AtlanticIntroBack.SetActive(false);
        ActUnavailable.SetActive(true);
        Invoke("Accuracy",1); 
        
    }

     void postStart(){
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
     }
//0: Contnet accuracy 
    void Accuracy(){
        contentAccuracy.SetActive(true);
        startTalking("The following visualisation is an approximate representation based upon historical evidence.");
        Invoke("contentAccuracyClose",7);  
    }
void contentAccuracyClose(){
        contentAccuracy.SetActive(false);
        //IntroSlavery();
        Invoke("IntroSlavery",1);
    }

//01: what is slavery into + talk + skip button
    void IntroSlavery(){
        introSlav.SetActive(true);
        VoiceController.stopSpeackingSlavery = true; 
        //slavery
        startTalking("In the Western tradition, slavery is contrasted with freedom: whereas a ‘free’ individual enjoyed basic rights of citizenship, choice of occupation and lifestyle, and security of person and property, the slave was a chattel with hereditary status. The slave owner, who legally could punish, sell or transfer a slave, and separate a slave mother from her children or male companion, controlled the slave’s productive and reproductive capacities. Slaves thus formed a separate economic group, a ‘chattel’ class that possessed no communality of interests with the ‘free’ working class. Some posit that where slave labour predominated, as on slave plantations, the economy was characterized by a ‘slave mode of production’. ");     
    }

    public void SkipIntro(){
        stopTalking();
        Destroy(introSlav);
        Destroy(contentAccuracy);
        ChooseSlavery();
    }

//02: choose slavery (Arab v. Western)
    void ChooseSlavery(){
        initMenu.SetActive(true); 
        VoiceController.stopSpeackingSlavery = false; 
        }

    

//03: Arab Intro
void ArabIntro(){
       if(count <=1){
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
        ActUnavailable.SetActive(true);
        FindObjectOfType<MarkerStates>().CNotFound(); 
        Destroy(initMenu); 
        Destroy(AtlanticSea);
        Destroy(AtlanticIntroBack);
        SlaveryIntroDone = true;
        VoiceController.stopSpeacking = true;
        ArabIntroBack.SetActive(true);
        ArabEarth.SetActive(true);
        startTalking("The trans-Saharan, Indian Ocean & Red Sea slavery waves are often referred as The Arab slave trade. This is due to the various periods in which the slave trade has been carried out under the auspices of Arab peoples or Arab countries. Slavery was practised in Arabia as in the rest of the ancient world well before the advent of Islam early in the seventh century a.D. The existence of foreign slaves, mostly dark-skinned (and a few white people), is echoed in ancient Arabic poetry and pre-Jslamic traditions. Immediately before the coming of Islam, Western Arabia in general and Mecca in particular had witnessed the presence of large numbers of African slaves, mostly Ahbash or Abyssinians. The term Habash or Ahbash has a wider connotation and under it are lumped most of the dark - skinned people of the western coast of the Red Sea. This was probably due to the fact that the Arabs' knowledge of Africa was then restricted to Abyssinia and its neighbouring regions. Yet the Arabs were neither the first to introduce slavery and the slave trade among (black) Africans, nor were they the first to enslave them. Slavery or a form of serfdom and the selling of slaves was a fairly common phenomenon in many parts of the African continent. Furthermore, both the Pharaohs and the Romans were already involved in procuring black African slaves. Indeed, the presence of  African slaves engraved on Egyptian monuments bears witness to the antiquity of slavery. Nonetheless the Arabs were probably the first outsiders to penetrate deep into the African habitat and to meet the great demand for slaves in the Islamic world. It was through their intervention that the slave trade received further stimulus and assumed great importance.");
       } 
     }
void StartTracking(){
    //print("strat tracking");
    stopTalking();
    Resources.UnloadUnusedAssets();
    System.GC.Collect();
    IntroDone = true;
    TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
    FindObjectOfType<MarkerStates>().NotFound(); 
}

//03.1 skip Arab Intro
    public void SkipArabIntro(){
        VoiceController.stopSpeacking = false;
        Destroy(ArabIntroBack);
        Destroy(ArabEarth);
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
        //TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        Invoke("StartTracking",2);
    }

//04: Western Into
void WestIntro(){
       if(Wcount <=1){
           TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
           ActUnavailable.SetActive(true);
           FindObjectOfType<MarkerStates>().CNotFound(); 
           Destroy(initMenu); 
           Destroy(ArabIntroBack); 
           Destroy(ArabEarth); 
           VoiceController.stopAtlanticSpeacking = true;
           print("WestIntro Play");
           AtlanticSea.SetActive(true);
        AtlanticIntroBack.SetActive(true);
        startTalking("African slavery has represented one of the largest—albeit coerced—migration experiences in history. Over the five centuries running from 1400 to 1900, the slave trade encompassed four distinct waves: the trans-Saharan, Indian Ocean, Red Sea, and trans-Atlantic slave trades. The last one was by far the most significant in terms of volume and duration: over the 1529–1850 period, over 12 million Africans were embarked, mostly along the coasts of West Africa, and forced to undertake the Middle Passage across the Atlantic Ocean. The peak was reached between 1780 and 1790, with 80,000 slaves per year being transported, but the traffic remained very intense during the nineteenth century, when between three and four million people were embarked. Britain culminated in the eighteenth century. France also had a prominent role, followed by Spain, the Netherlands, and the USA. The decline started after 1807, even though the process was very slow and became significant only after mid-nineteenth century when Brazil joined in. The three other slave trades pre-dated the trans-Atlantic wave and followed different paths: the trans-Saharan trade took people from the subSaharan regions to Northern Africa, while both the Indian Ocean and the Red Sea trades took people from Eastern Africa and delivered them to various parts of Asia.");
           
       } 
     }

     //04.1: Western SKIP Into
     public void SkipAtlanticIntro(){
        VoiceController.stopAtlanticSpeacking = false;
        Destroy(AtlanticSea);
        Destroy(AtlanticIntroBack);
        Resources.UnloadUnusedAssets();
      System.GC.Collect();
        //TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        Invoke("StartTracking",2);
    }

//05: marker 

    public void activeScreen(Button activeBtn) {
        print("0 running!!!!");
        if (activeBtn.transform.name == "sahaBtn")
        {
           // print("saha clciked");
            count++;
            sahaBack.SetActive(true);
            screenName.text = "trans-Saharan Slavery";
            MarkerStates.currentScreen = "sahaBtn";
            currentScreen = "sahaBtn";
            FindObjectOfType<MarkerStates>().destroyAt();
            if(IntroDone == false){
            indBack.SetActive(false);
            redBack.SetActive(false);
            atlBack.SetActive(false);
            initMenu.SetActive(false);
             ArabIntro();
            }
           
        } 
        else if (activeBtn.transform.name == "IndBtn")
        {
           // print("indi clciked");
            count++;
            indBack.SetActive(true);
            screenName.text = "Indian Ocean Slavery";
            MarkerStates.currentScreen = "IndBtn";
            currentScreen = "IndBtn";

            if(IntroDone == false){
            sahaBack.SetActive(false);
            redBack.SetActive(false);
            atlBack.SetActive(false);
            initMenu.SetActive(false);
            ArabIntro();
            }

        }
        else if (activeBtn.transform.name == "RedBtn")
        {
            //print("red clciked");
            count++;
            redBack.SetActive(true);
            screenName.text = "Read Sea Slavery";
            MarkerStates.currentScreen = "RedBtn";
            currentScreen = "RedBtn";

            if(IntroDone == false){
            sahaBack.SetActive(false);
            indBack.SetActive(false);
            atlBack.SetActive(false);
            initMenu.SetActive(false);
            ArabIntro();
            }
  
        }
        else 
        {
            //print("atlan clciked");
            Wcount++;
            atlBack.SetActive(true);
            screenName.text = "trans-Atlantic Slavery";
            MarkerStates.currentScreen = "atlan";
            currentScreen = "atlan";
            FindObjectOfType<MarkerStates>().destroySaha();
            if(IntroDone == false){
            sahaBack.SetActive(false);
            redBack.SetActive(false);
            indBack.SetActive(false);
            initMenu.SetActive(false);
            WestIntro();
            }
            
        }
        FindObjectOfType<MarkerStates>().CurrentBtn(); 
    }


    //spoke
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }

  
}
