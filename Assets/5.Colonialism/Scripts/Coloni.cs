using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloni : MonoBehaviour
{
    public GameObject ActionButtons, BackgroundTexts; 

    public GameObject Europe, EuropeTalks, Africa, AfricaTalks, moreInfo;
    //EUROPE
    public GameObject Table, King;
    Vector3 TablePos, KingPos;
    public GameObject TableTxt, KingTxt;
    //AFRICA
    public GameObject ScrambleA, ScumbleIntroText, closeBtn, NaturalRes, CutureLang;
    Vector3 ScrambleAPos, NaturalResPos, CutureLangPos, ScumblePercentPos, ScumbleInfoPos, LanguagesPos, CulturePos, populationPos;

    /*Scramble*/ public GameObject ScumblePercent, ScumbleInfo, ScrumbleTalkss;
    /*Scramble TEXT*/ public GameObject ScumblePercentTEXT, ScumbleInfoTEXT;
    /*NaturalRes*/ public GameObject NaturalResText;

    /*CutureLang*/ public GameObject Languages, Culture, population, CultureTalks;
    public GameObject LanguagesTxt, CultureTxt, populationTxt;

    //More Info
    public GameObject Irish, Military, European, Roman, Black, MTalks;
    public GameObject IrishTxt, MilitaryTxt, EuropeanTxt, RomanTxt, BlackTxt;
    Vector3 IrishPos, MilitaryPos, EuropeanPos, RomanPos, BlackPos;

    int firsttime;
    public static string objName, currentTxt, currentSelecetdButton;
    bool isTalking;

    // Start is called before the first frame update
    void Start()
    {
        allOff();
      TablePos = Table.transform.localScale;
      KingPos = King.transform.localScale;
      ScrambleAPos = ScrambleA.transform.localScale;
      NaturalResPos = NaturalRes.transform.localScale;
      CutureLangPos = CutureLang.transform.localScale;
      ScumblePercentPos = ScumblePercent.transform.localScale;
      ScumbleInfoPos = ScumbleInfo.transform.localScale;
      LanguagesPos = Languages.transform.localScale;
      CulturePos = Culture.transform.localScale;
      populationPos = population.transform.localScale;
      IrishPos = Irish.transform.localScale; 
      MilitaryPos = Military.transform.localScale;
      EuropeanPos = European.transform.localScale;
      RomanPos = Roman.transform.localScale;
      BlackPos = Black.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
     {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;

            switch (objName)
            {
                //EUROPE

                case "LeoTalk": 
                europeASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                EuropeTalks.SetActive(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                King.SetActive(true); 
                KingTxt.SetActive(true); 
                currentTxt = "LeoTalk";
                currentSelecetdButton = "Europe";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "TableTalk": 
                europeASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                EuropeTalks.SetActive(false);
                ColoniMText.CurrentMTxt = "TableTalk";
                TextSatus(true);
                Table.SetActive(true); 
                TableTxt.SetActive(true); 
                currentTxt = "TableTalk";
                currentSelecetdButton = "Europe";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;
                
                //AFRICA
//SCRUMBLE 
                case "ScrambleTitle": 
                CloseAfricaScrumbleOption();
                Invoke("AssetTalk",1);
                break;

                //SCRUMBLE: OPTIONS
                case "ScumblePercentTalk": 
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                ScumbleInfo.SetActive(false);
                ScrumbleTalkss.SetActive(false);
                closeBtn.SetActive(false); 
                ScumblePercent.SetActive(true);
                ScumblePercentTEXT.SetActive(true);
                currentTxt = "ScumblePercentTalk";
                currentSelecetdButton = "AfricaScrumbleOptionClose";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "ScumbleInfoTalk": 
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                ScumblePercent.SetActive(false);
                ScrumbleTalkss.SetActive(false);
                closeBtn.SetActive(false); 
                ScumbleInfo.SetActive(true);
                ScumbleInfoTEXT.SetActive(true);
                currentTxt = "ScumbleInfoTalk";
                currentSelecetdButton = "AfricaScrumbleOptionClose";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                
//NATURAL RESOURCES PRESSED
                case "NaturalResTitle": 
                africaMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                AfricaTalks.SetActive(false);
                ColoniMText.CurrentMTxt = "NaturalResTitle";
                TextSatus(true);
                NaturalRes.SetActive(true); 
                NaturalResText.SetActive(true); 
                NaturalRes.transform.localScale = new Vector3(7.87816f,1f,7.87816f);
                currentTxt = "NaturalResTitle";
                currentSelecetdButton = "Africa";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;
                
//CULTURE PRESSED
                case "CutureTitle": 
                CloseAfricaCultureOption();
                break;

                //CULTURE: OPTIONS
                case "LangauegsTalk": 
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                Culture.SetActive(false); 
                population.SetActive(false);
                CultureTalks.SetActive(false);
                Languages.SetActive(true);
                LanguagesTxt.SetActive(true);
                closeBtn.SetActive(false); 
                currentTxt = "LangauegsTalk";
                currentSelecetdButton = "AfricaCultureOptionClose";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "TibeTalk": 
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                CultureTalks.SetActive(false);
                population.SetActive(false);
                Languages.SetActive(false);
                Culture.SetActive(true); 
                CultureTxt.SetActive(true);
                closeBtn.SetActive(false); 
                currentTxt = "TibeTalk";
                currentSelecetdButton = "AfricaCultureOptionClose";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "populationTalk": 
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                CultureTalks.SetActive(false);
                Languages.SetActive(false);
                Culture.SetActive(false); 
                population.SetActive(true);
                populationTxt.SetActive(true);
                closeBtn.SetActive(false); 
                currentTxt = "populationTalk";
                currentSelecetdButton = "AfricaCultureOptionClose";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;
//MORE INFO PRESSED
                case "blackTalk": 
                MoreInfoMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                Black.SetActive(true); 
                BlackTxt.SetActive(true); 
                MTalks.SetActive(false); 
                currentTxt = "blackTalk";
                currentSelecetdButton = "MoreInfo";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MilitaryTalk": 
                MoreInfoMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                Military.SetActive(true); 
                MilitaryTxt.SetActive(true); 
                MTalks.SetActive(false); 
                currentTxt = "MilitaryTalk";
                currentSelecetdButton = "MoreInfo";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "romanTalk": 
                MoreInfoMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                Roman.SetActive(true); 
                RomanTxt.SetActive(true); 
                MTalks.SetActive(false); 
                currentTxt = "romanTalk";
                currentSelecetdButton = "MoreInfo";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "EuropeanTalk": 
                MoreInfoMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                European.SetActive(true); 
                EuropeanTxt.SetActive(true); 
                MTalks.SetActive(false); 
                currentTxt = "EuropeanTalk";
                currentSelecetdButton = "MoreInfo";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "IrishTalk": 
                MoreInfoMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                Irish.SetActive(true); 
                IrishTxt.SetActive(true); 
                MTalks.SetActive(false); 
                currentTxt = "IrishTalk";
                currentSelecetdButton = "MoreInfo";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;
                
                default: 
                break;

            }
        }
        
    }
    }

//COMMON METHODS

    void TextSatus(bool st){
        ActionButtons.SetActive(st);
        BackgroundTexts.SetActive(st);
        ScaleandRotate.Isenabled = st;
        FindObjectOfType<ColoniMText>().BookIcon();
        stopTalking();
        TableTxt.SetActive(false); 
        KingTxt.SetActive(false); 
        ScumbleIntroText.SetActive(false); 
        ScumblePercentTEXT.SetActive(false); 
        ScumbleInfoTEXT.SetActive(false); 
        NaturalResText.SetActive(false);
        LanguagesTxt.SetActive(false);
        CultureTxt.SetActive(false);
        populationTxt.SetActive(false);
        IrishTxt.SetActive(false);
        MilitaryTxt.SetActive(false);
        EuropeanTxt.SetActive(false);
        RomanTxt.SetActive(false);
        BlackTxt.SetActive(false);
    }

    public void closeIntercativeModel(){
        if(currentSelecetdButton == "Europe"){
            stopTalking(); 
            BerlinConf();
        }else if(currentSelecetdButton == "Africa"){
            stopTalking(); 
            Scramble();
        }else if (currentSelecetdButton == "AfricaScrumble"){
            TextSatus(false);
            closeBtn.SetActive(true); 
        }else if (currentSelecetdButton == "AfricaScrumbleOptionClose"){
            CloseAfricaScrumbleOption();
        }else if(currentSelecetdButton == "AfricaCultureOptionClose"){
            CloseAfricaCultureOption();
            ResetSize();
        }else if(currentSelecetdButton == "MoreInfo"){
            stopTalking(); 
            AddInfo();
            ResetSize();
        }

    }

   public void clsbtn(){
        closeBtn.SetActive(false); 
    }
    void CloseAfricaScrumbleOption(){
        africaMAINASSETSFalse(false);
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                ActionButtons.SetActive(false);
                AfricaTalks.SetActive(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(true);
                ScrambleA.SetActive(true); 
                ScumbleIntroText.SetActive(true); 
                ScumblePercent.SetActive(true);
                ScumbleInfo.SetActive(true);
                ScrumbleTalkss.SetActive(true);
                currentTxt = "ScrambleTitle";
                currentSelecetdButton = "AfricaScrumble";
                isTalking = true;
                ResetSize();
    }

    void CloseAfricaCultureOption(){
                FindObjectOfType<ColonialMarker>().ButtonsStatus(false);
                closeBtn.SetActive(true); 
                ActionButtons.SetActive(false);
                AfricaTalks.SetActive(false);
                ColoniMText.CurrentMTxt = "none";
                TextSatus(false); 
                Languages.SetActive(true); 
                Culture.SetActive(true); 
                population.SetActive(true); 
                CultureTalks.SetActive(true); 
                ScrambleA.SetActive(false);
                NaturalRes.SetActive(false);
                currentTxt = "CutureTitle";
                currentSelecetdButton = "Africa";
                
    }

    public void closeAfriShamb(){
        Scramble();
    }

    void ResetSize(){
    Table.transform.localScale = TablePos; 
    King.transform.localScale = KingPos;
    ScrambleA.transform.localScale = ScrambleAPos;
    NaturalRes.transform.localScale = NaturalResPos;
    NaturalRes.transform.Rotate(0f, 0f, 0f);
    CutureLang.transform.localScale = CutureLangPos;
    ScumblePercent.transform.localScale = ScumblePercentPos;
    ScumblePercent.transform.Rotate(0f, 0f, 0f);
    ScumbleInfo.transform.localScale = ScumbleInfoPos; 
    ScumbleInfo.transform.Rotate(0f, 0f, 0f);
    Languages.transform.localScale = LanguagesPos; 
    Languages.transform.Rotate(0f, 0f, 0f);
    Culture.transform.localScale = CulturePos;
    population.transform.localScale = populationPos;
    Irish.transform.localScale = IrishPos; 
    Military.transform.localScale = MilitaryPos;
    European.transform.localScale = EuropeanPos;
    Roman.transform.localScale = RomanPos;
    Black.transform.localScale = BlackPos;
        print("ResetSize");
    }
    

    public void allOff(){
        Europe.SetActive(false);
        Africa.SetActive(false);
        moreInfo.SetActive(false);
        TextSatus(false);
    }

    public void AssetTalk(){
        if(isTalking == true){
    switch(currentTxt)
        {
            case "LeoTalk":   
            startTalking("Of the Europeans who scrambled for control of Africa at the end of the 19th century, Belgium's King Leopold II left arguably the largest and most horrid legacy of all. While the Great Powers competed for territory elsewhere, the king of one of Europe's smallest countries carved his own private colony out of 100km2 of Central African rainforest. He claimed he was doing it to protect the natives from Arab slavers, and to open the heart of Africa to Christian missionaries, and Western capitalists. He turned his Congo Free State into a massive labour camp, made a fortune for himself from the harvest of its wild rubber, and contributed in a large way to the death of perhaps 10 million innocent people.");
            isTalking = false;
            break;

            case "TableTalk":   
            startTalking("At the Berlin West Mrica Conference 1884-85 the European Powers laid down rules and procedures for the annexation of territory in Africa. This was, in effect, a way of ensuring that the partition of the continent should be carried out without serious conflict between the powers. The very fact of laying down rules and procedures under which powers could 'legitimately' lay claim to Mrican territory by means of effective occupation lent a dynamic and rationale to European expansion. There was now nothing 'absent minded'- in Seeley's words - about European imperialism. The conference was also a forum in which Bismarck played out his diplomatic manoeuvres, in this case seeking a rapprochement - abortive as it turned out - with France.");
            isTalking = false;
            break;

            //SCRUMBLE SELECTED
            case "ScrambleTitle":   
            startTalking("Within the historical context of Africa, the most important potentially omitted factor is colonial rule, which followed the slave trade and lasted from 1885 until inde pendence.  The 'scramble for Africa' is a metaphor applied by historians to the period of very rapid annexation of the African continent by the European Powers in the last two decades of the nineteenth century. It is a much debated historical process upon which strong opinions and diverse views are held. The scramble was indeed a truly remarkable episode representing, perhaps, the most rapid period of imperial expansion in history.");
            isTalking = false;
            break;
            //SCRUMBLE OPTIONS CLICKED
            case "ScumblePercentTalk":   
            startTalking("European imperialists invaded Africa on the pretext that Africans were incapable of properly governing themselves; once established there, however, they found they were unable to govern without the participation of African allies and intermediaries. The map showcases to what extent Africa was colonized by 1914 at the beginning of the first world war. As you can see, the country that held the greatest number of colonies in Africa was, the United Kingdom, France, Portugal, Germany, Belgium, Italy. In terms of the population held under these colonial powers; United Kingdom with 30%, France with 15%, Portugal with 11%, Germany with 9%, Belgium with 7%, Italy with 1%. Together, these colonial powers controlled almost 90% of Africa and only Abyssinia (Modern Ethiopia) and Liberia were independent. What must be highlighted here is that before 1914, by 1880, most of Africa was not occupied by the Europeans. However, within the short period of the next 30 years from 1880, the Europeans conquered almost all the continent. By 1914, as we mentioned earlier, 90% of Africa was controlled by the Europeans.");
            isTalking = false;
            break;
            case "ScumbleInfoTalk":   
            startTalking("The Scramble for Africa starts in the 1860s when the French and the British begin the systematic exploration of West Africa, signing bilateral agreements on spheres of influence. During the next 40 years, Europeans signed hundreds of treaties that divided the largely unexplored continent into protectorates, free-trade areas, and colonies. The event that stands for the partitioning of Africa is the conference that Otto von Bismarck organized in Berlin from November 1884 until February 1885. In line with the historical evidence, Alesina, Easterly, and Matuszesk document that 80 percent of African borders follow latitudinal and longitudinal lines, more than in any other parts in the world. Wesseling summarizes the situation: The partition of Africa was recorded by the Europeans on their maps, but the matter rested there for the time being. ... In Europe conquests preceded the drawing of maps, in Africa the map was drawn, and then it was decided what was going to happen. These maps did not therefore reflect reality but helped to create it. ");
            isTalking = false;
            break;

            //NATURAL RESOURCES CLICKED
            case "NaturalResTitle":   
            startTalking("Many countries experienced high growth towards the end of the colonial period. When most African economies regained their independence, sustained growth in Africa became more prevalent: in 1967- 1968, half of Africa’s economies were in the middle of a decade of sustained rapid growth. This trend was reversed at the beginning of the 1970s. History has shown that African countries are particularly vulnerable to economic downturns. In times of economic depression, political instability and inefficiency have proven particularly harmful for economic growth. All economies have been hit by external shocks in the past, but African economies were hit harder and took longer to recover. ");
            isTalking = false;
            break;

            //CULTURE CLICKED
            case "LangauegsTalk":   
            startTalking("Like the rest of the world, Africa is home to a dizzying array of local dialects often unintelligible to foreigners. Unlike much of the world, though, Africa’s colonial experience brought several European languages to the continent, making communication somewhat easier. What is impressive though is the magnitude of it; Africa is home to 2,092 languages in active use. ");
            isTalking = false;
            break;

            case "TibeTalk":   
            startTalking("The large tribal division of modern Africa arose primarily because of European colonization. In an effort to manage them better, colonial leaders often lumped disparate ethnic groups together into large tribes. This simplified running large colonies with small European staffs, and Africans soon realized that conforming to the tribal classifications eased their dealings with Europeans. However, like the state borders imposed by Europeans, the composition of tribes and the power accrued by their leaders created a situation ripe for conflict. This dysfunctional tribal system still existed when African nations gained their independence and was unsuited to the challenges of sovereign statehood. It was thus a ready scapegoat for the many failures of recently independent African states.");
            isTalking = false;
            break;

            case "populationTalk":   
            startTalking("Population estimates from the pre-colonial Gold Coast are very uncertain. What crude estimates there are suggest that the population might have amounted to between 1.3 and 2.3 million people in the year 1850, after possibly having decreased for several centuries as a consequence of the slave trade.");
            isTalking = false;
            break;

            case "blackTalk":   
            startTalking("European discourses about Africans make it clear that even before the actual enslavement and colonial plunder of Africans began, racist stereotypes which were obsessed with colour and nakedness were well in place. In fact in several colonial situations these stereotypes provided an ideological justification for different kinds of exploitation. Therefore the relationship between racial ideologies and exploitation is better understood as dialectical, with racial assumptions both arising out of and structuring economic exploitation. ");
            isTalking = false;
            break;

            case "MilitaryTalk":   
            startTalking("Moreover, military violence was used almost everywhere, although to different degrees, to secure both occupation and trading ‘rights’: the colonial genocide in North America and South Africa was spectacular. In the ‘scramble for Africa’, only Ethiopia held out because of her technological and military superiority.");
            isTalking = false;
            break;

            case "romanTalk":   
            startTalking("Racial stereotyping is not the product of modern colonialism alone, but goes back to the Greek and Roman periods which provide some abiding templates for subsequent European images of ‘barbarians’ and outsiders. Early colonial discourses distinguished between people regarded as barbarous infidels (such as the inhabitants of Russia, Central Asia, Turkey) and those who were constructed as savage (such as the inhabitants of the Americas and Africa).");
            isTalking = false;
            break;

            case "EuropeanTalk":   
            startTalking("With European colonial expansion, and nation-building, these earlier ideas (and their contradictions) were intensified, expanded and reworked. Despite the enormous differences between the colonial enterprises of various European nations, they seem to generate fairly similar stereotypes of ‘outsiders’—both those outsiders who roamed far away on the edges of the world, and those who (like the Irish) lurked uncomfortably nearer home. Thus laziness, aggression, violence, greed, sexual promiscuity, bestiality, primitivism, innocence and irrationality are attributed (often contradictorily and inconsistently) by the English, French, Dutch, Spanish and Portuguese colonists to Turks, Africans, Native Americans, Jews, Indians, the Irish, and others.");
            isTalking = false;
            break;

            case "IrishTalk":   
            startTalking("In some cases, colour was the most important signifier of cultural and racial difference (as in the representations of Africans) and in other cases it was less remarked upon (as in the case of the Irish). In fact the lack of colour difference intensified the horror of the colonial vis-à-vis the Irish. Thus Charles Kingsley observed after his first trip to Ireland: ‘I am haunted by the human chimpanzees I saw along that hundred miles of horrible country.… But to see white chimpanzees is dreadful; if they were black, one would not feel it so much, but their skins, except where tanned by exposure, are as white as ours’.");
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

    public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }


 

   ///EUROPE SELECTED

    public void BerlinConf(){
        FindObjectOfType<ColonialMarker>().ButtonsStatus(true);
        allOff();
        ResetSize();
        Europe.SetActive(true);
        europeASSETSFalse(true);
        EuropeTalks.SetActive(true);
        currentSelecetdButton = "none";
        stopTalking();
    }

   void europeASSETSFalse(bool stat){
        Table.SetActive(stat);
        King.SetActive(stat);
    }

//AFRICA SELECTED
    public void Scramble(){
        stopTalking();
        FindObjectOfType<ColonialMarker>().ButtonsStatus(true);
        allOff();
        ResetSize();
        Africa.SetActive(true);
        africaMAINASSETSFalse(true);
        AfricaTalks.SetActive(true);
        currentSelecetdButton = "none";
        //Scrumble content false
        ScumbleInfo.SetActive(false);
        ScrumbleTalkss.SetActive(false);
        closeBtn.SetActive(false);  
        firsttime++;
        //culture
        Languages.SetActive(true); 
        Culture.SetActive(false); 
        population.SetActive(false); 
        CultureTalks.SetActive(false);
        if(firsttime <= 1){
            Invoke("instructionsF", 2);
        }
        
    }

    void instructionsF(){
        startTalking("Welcome to the colonial period of the scramble for Africa. Please click one of the three maps (preferably the title) so that you can start your AR experience. ");
    }
    
    void africaMAINASSETSFalse(bool stat){
        ScrambleA.SetActive(stat);
        NaturalRes.SetActive(stat);
        CutureLang.SetActive(stat);
    }




    public void AddInfo(){
        FindObjectOfType<ColonialMarker>().ButtonsStatus(true);
        allOff();
        ResetSize();
        moreInfo.SetActive(true);
        MoreInfoMAINASSETSFalse(true);
        MTalks.SetActive(true); 
        currentSelecetdButton = "none";
        stopTalking();

    }

    void MoreInfoMAINASSETSFalse(bool stat){
        Irish.SetActive(stat);
        Military.SetActive(stat);
        European.SetActive(stat);
        Roman.SetActive(stat);
        Black.SetActive(stat);
    }


}
