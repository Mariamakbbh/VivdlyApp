using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniMText : MonoBehaviour
{
    public GameObject TableMTxt, NaturalResMText; 
    public GameObject BackgroundTexts, backblurr, OnlineExplore, book;
    public static string CurrentMTxt;
    bool isTalking;

    public void BookIcon(){
        if(CurrentMTxt == "none"){
        book.SetActive(false);
        return;
    }else{
        book.SetActive(true);
    }
    }

    //open additional info
public void BookMoreText(){
    if(CurrentMTxt == "none"){
        book.SetActive(false);
        return;
    }else{
    BackgroundTexts.SetActive(true);
    backblurr.SetActive(true);
    OnlineExplore.SetActive(true);
    book.SetActive(true);
    
    switch(CurrentMTxt)
        {
            //EUROPE
            case "TableTalk":
            stopTalking();
            TableMTxt.SetActive(true);
            CurrentMTxt = "TableTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            //AFRICA
            case "NaturalResTitle":
            stopTalking();
            NaturalResMText.SetActive(true);
            CurrentMTxt = "NaturalResTitle";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            default:
            break;
        }
    }
}


//close all
public void CloseMoreText(){
    closemtext();
    stopTalking();
}

public void closemtext(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    isTalking = false;
    //ASSETS
    TableMTxt.SetActive(false);
    NaturalResMText.SetActive(false);
    

}

//talking

public void OpenTalk(){
    if(isTalking == true){
    switch(CurrentMTxt)
        {
            //EUROPE
            case "TableTalk":
            startTalking("The Berlin West Africa Conference (and the Act it promulgated) is often regarded as pivotal in the developing momentum of the scramble. Representatives of fourteen countries met in Berlin in November 1884 at the invitation of Germany and France. It was preceded and precipitated by growing tensions and rivalries in West Africa mainly over control of the Congo basin, but also over territories elsewhere particularly along the River Niger. Stanley had conducted an expedition on the Congo for King Leopold of Belgium in order to establish Belgian influence there and he met the Frenchman De Brazza who was engaged in a similar exploit on behalf of the French. This was accompanied by the ritual signing of treaties with local chiefs - notably the famous treaty with Makoko which was ratified by the French parliament in a blaze of imperialist publicity. The British and Portuguese meanwhile signed a treaty in February 1884 giving Portugal control of both mouths of the Congo.");
            isTalking = false;
            break;

            //AFRICA
            case "NaturalResTitle":
            startTalking("After the second oil price shock in 1979-1981, only a handful of countries achieved sustained growth in the 1980s. Until recently, the improvement was very slight. But in 1998, 25% of African economies began experiencing sustained growth again. The primary drivers of economic growth in the past were linked first of all to the demand for African minerals and agricultural products in world markets. Economic policy and political governance has played an important role, too. ");
            isTalking = false;
            break;

            default:
            break;
        }
    }else{
        stopTalking();
        isTalking = true;
    }

}

//additional resources WEB 
public void ExternalSiteMoreText(){
    if(CurrentMTxt == "TableTalk"){
        Application.OpenURL("http://news.bbc.co.uk/1/hi/world/africa/3516965.stm");
    
    } else if(CurrentMTxt == "NaturalResTitle"){
        Application.OpenURL("https://www.aljazeera.com/news/2018/2/20/mapping-africas-natural-resources ");
    
    }else{
        OnlineExplore.SetActive(false);
    }
}


    //additional resources BOOK 
public void ExternalBookMoreText(){
    if(CurrentMTxt == "TableTalk"){
        Application.OpenURL("https://www.google.co.uk/books/edition/The_Scramble_for_Africa/zjNdDwAAQBAJ?hl=en&gbpv=0");
    
    }else{
        OnlineExplore.SetActive(false);
    }

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