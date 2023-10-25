using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaliMoreInfo : MonoBehaviour
{
    public GameObject BackgroundMaliTexts;
    public GameObject MusaMoreText;
    public GameObject MuslimMoreText;
    public GameObject backblurr;
    bool isTalking;
    public static string currentTxt;

void Start(){
    isTalking = false;
    CloseMoreText();
}

//open additional info
public void BookMoreText(){
    BackgroundMaliTexts.SetActive(true);
    backblurr.SetActive(true);
    
    switch(currentTxt)
        {
            case "musa":   
            FindObjectOfType<Mali>().MusaMoreText(false);
            stopTalking();
            MusaMoreText.SetActive(true);
            currentTxt = "musa";
            isTalking = true;
            break;


            case "muslim":
            FindObjectOfType<Mali>().MuslimMoreText(false);
            stopTalking();
            MuslimMoreText.SetActive(true);
            currentTxt = "muslim";
            isTalking = true;
            break;

            default:
            print("Nothing open"); 
            break;
        }
    }

//closeText
public void CloseInText(){
    switch(currentTxt)
        {
            case "musa":   
            CloseMoreText();
            FindObjectOfType<Mali>().MusaMoreText(true);
            break;


            case "muslim":
            CloseMoreText();
            FindObjectOfType<Mali>().MuslimMoreText(true);
            break;

            default:
            print("Nothing close"); 
            break;
        }
    }



//close all
public void CloseMoreText(){
    BackgroundMaliTexts.SetActive(false);
    backblurr.SetActive(false);
    MusaMoreText.SetActive(false);
    MuslimMoreText.SetActive(false);
    FindObjectOfType<ScaleInOut>().ResertSizeMali();
    isTalking = false;
}



//spoke
public void startTalking(string message){
       FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
       FindObjectOfType<foundMarker>().StopTalkingAnim();
  }



//talking

public void OpenTalk(){
    if(isTalking == true){
    switch(currentTxt)
        {
            case "musa":   
            startTalking("Mansa  Musa  was  famous  for  his  piety  (devotion  to  his  religion)  and generosity.  His  25-year  reign,  from  1312  to  1337,  is  thought  of  as  the golden  age  of  Mali. Historians estimate that Mansa Musa, in modern currency, was worth around $400bn. That is more than twice as wealthy as Amazon’s Jeff Bezos – the richest person alive today. Most of Mansa Musa’s wealth came from gold and salt. Islamic  scholar  Ibn  Kathir  (ca.  1300–ca.  1374) reported  that  Mansa  Musa  was  a  young,  handsome  man  who  had  24 lesser kings under his authority. Al-Umari  was  told  that  Musa  had  “conquered  24  cities,  each with  its  surrounding  district  with  villages  and  estates”, and that his palace was rich and splendid. The  royal  flag  that  flew  over  Mansa  Musa  when  he  rode  out  on horseback  was  yellow  with  a  red  background.  When  the  mansa  officially  met  with  people,  he  carried  gold  weapons,  including  a  bow  and arrows (symbols of royal power in Mali). Mansa  Musa  sat  on  a  large  ebony  throne  that  was  on  a  raised  platform  with  elephant  tusks  along  the  sides.  Behind  the  king  stood  about 30  slaves,  including  ones  from  Turkey  and  Egypt.  Over  the  mansa’s head,  one  of  the  slaves  held  a  large  silk  sunshade  topped  by  a  golden falcon. The  lesser  kings  sat  in  two  rows  on  both  sides,  and  beyond  them were  the  commanders  of  the  cavalry.  In  front  of  the  mansa  stood  the sword  bearer  or  chief  executioner,  and  a  chief  spokesman  called  a  jeli /or griots. The  mansa  never  spoke  aloud  in  public,  but  whispered  what  he  wanted to say to the  jeli, who would make the announcements. Music  accompanied  his  public  appearances.  There  were  different size  drums,  trumpets  made  of  elephant  tusks,  and  a  kind  of  xylophone called  the  bala  that  is  famous  for  its  beautiful  sound.  There  were  always two  horses  (far  more  expensive  than  camels)  tied  nearby,  ready  for  the mansa  to ride whenever he needed them.");
            isTalking = false;
            break;


            case "muslim":
            startTalking("Mansa Musa was a devout Muslim, and observed one of the five pillars of Islam by undertaking a pilgrimage to Mecca (known as Hajj). Of  all  the  sub-Saharan  West  African  rulers  who  made  the  pilgrimage  to Mecca,  Mansa  Musa  was  the  most  famous.  When  he  was  preparing  for the  journey,  he  consulted  his  diviners  to  find  out  the  best  time  to  leave. The  diviners  told  Mansa  Musa  he  should  wait  until  a  Saturday  that would  fall  on  the  12th  day  of  the  month.  This  meant  he  had  to  wait  nine months before he could leave—which he did. The  journey  across  the  Sahara  Desert  took  about  a  year  and  was extremely  difficult.  Thousands  of  people  are  said  to  have  accompanied Mansa  Musa.  The  king  took  along  his  senior  wife,  Inari  Kanuté,  who had  hundreds  of  her  own  servants  and  slaves.  There  were  also  Muslims from  among  the  Mali  court  officials  and  merchant  community,  soldiers to protect the caravan, camel drivers, servants, and slaves. There  were  thousands  of  camels  and  donkeys  to  carry  food,  water, and  other  supplies.  The  caravan  is  said  to  have  included  80  loads  of gold  dust.  In  addition  to  the  animals,  there  were  slaves  to  help  carry  the loads.  When  the  caravan  arrived  in  Egypt,  the  slaves  were  sold.  Later, others were purchased for the return journey. Mansu Musa was the richest person who ever lived. During his pilgrimage to Mecca, Mansa Musa gave away such a significant amount of gold that the economy of Cairo was affected for years after. Historian al-Umari said he “flooded Cairo with his kindness”.");
            isTalking = false;
            break;

            default:
                print("Nothing Talk"); 
                break;
        }
    }else{
        stopTalking();
        isTalking = true;
    }

}

//additional resources WEB 
public void ExternalSiteMoreText(){
    
    switch(currentTxt)
        {
            case "musa":   
            Application.OpenURL("https://www.youtube.com/watch?v=O3YJMaL55TM");
            break;

            case "muslim":
            Application.OpenURL("https://www.youtube.com/watch?v=jvnU0v6hcUo&t=238s");
            break;

            default:
            print("Nothing close"); 
            break;
        }
    }


    //additional resources BOOK 
public void ExternalBookMoreText(){
    Application.OpenURL("https://www.google.co.uk/books/edition/Empires_of_Medieval_West_Africa/mP2KSOvJHbMC?hl=en&gbpv=0");
    }







}
