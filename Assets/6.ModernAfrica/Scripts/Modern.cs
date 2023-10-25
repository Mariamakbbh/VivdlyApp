using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modern : MonoBehaviour
{
    public GameObject ActionButtons, BackgroundTexts; 
    public static string objName, currentTxt, currentSelecetdButton;
    bool isTalking;

    public GameObject ModernAfrica, Diaspora, Heros;
   
    //Modern
    public GameObject Africa, Conflict, people, land, trust, religions, ModernTalks;
    Vector3 AfricaPos, ConflictPos, peoplePos, landPos, trustPos, religionsPos;
    public GameObject ConflictTxt, peopleTxt, landTxt, trustTxt, religionsTxt;

    //Diaspora
    public GameObject  India, SriLanka, Mediterranean, Venezuela, Canada, Britain, Argentina, Russian, Brazil, Migration, Racism, Colourism, BloodPressure, DiasporaTalks;
    Vector3 IndiaPos, SriLankaPos, MediterraneanPos, VenezuelaPos, CanadaPos, BritainPos, ArgentinaPos, RussianPos, BrazilPos, MigrationPos, RacismPos, ColourismPos, BloodPressurePos; 
    public GameObject IndiaTxt, SriLankaTxt, MediterraneanTxt, VenezuelaTxt, CanadaTxt, BritainTxt, ArgentinaTxt, RussianTxt, BrazilTxt, MigrationTxt, RacismTxt, ColourismTxt, BloodPressureTxt; 

    //HEROS
    public GameObject Rosa, GeorgeF, FredHampton, Breonna, MalcomeX, MLK, Mandela, EnvironmetTalks;
    Vector3 RosaPos, GeorgeFPos, FredHamptonPos, BreonnaPos, MalcomeXPos, MLKPos, MandelaPos; 
    public GameObject RosaTxt, GeorgeFTxt, FredHamptonTxt, BreonnaTxt, MalcomeXTxt, MLKTxt, MandelaTxt;

    // Start is called before the first frame update
    void Start()
    {
        allOff();
       //MODERN
        ConflictPos = Conflict.transform.localScale;
        peoplePos = people.transform.localScale;
        landPos = land.transform.localScale;
        trustPos = trust.transform.localScale;
        religionsPos = religions.transform.localScale;

        //DIASPORA
        IndiaPos = India.transform.localScale;
        SriLankaPos = SriLanka.transform.localScale;
        MediterraneanPos = Mediterranean.transform.localScale;
        VenezuelaPos = Venezuela.transform.localScale;
        CanadaPos = Canada.transform.localScale;
        BritainPos = Britain.transform.localScale;
        ArgentinaPos = Argentina.transform.localScale;
        RussianPos = Russian.transform.localScale;
        BrazilPos = Brazil.transform.localScale;
        MigrationPos = Migration.transform.localScale;
        RacismPos = Racism.transform.localScale;
        ColourismPos = Colourism.transform.localScale;
        BloodPressurePos = BloodPressure.transform.localScale;

        //HEROS
        RosaPos = Rosa.transform.localScale;
        GeorgeFPos = GeorgeF.transform.localScale;
        FredHamptonPos = FredHampton.transform.localScale;
        BreonnaPos = Breonna.transform.localScale;
        MalcomeXPos = MalcomeX.transform.localScale;
        MLKPos = MLK.transform.localScale;
        MandelaPos = Mandela.transform.localScale;
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
                //MODERN AFRICA

                case "ConflictTalk": 
                MODERNASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                ModernTalks.SetActive(false);
                TextSatus(true);
                Conflict.SetActive(true); 
                ConflictTxt.SetActive(true); 
                currentTxt = "ConflictTalk";
                currentSelecetdButton = "ModernA";
                ModernMTxt.CurrentMTxt = "ConflictTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "peopleTalk": 
                MODERNASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                ModernTalks.SetActive(false);
                TextSatus(true);
                people.SetActive(true); 
                peopleTxt.SetActive(true); 
                currentTxt = "peopleTalk";
                currentSelecetdButton = "ModernA";
                ModernMTxt.CurrentMTxt = "peopleTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "TrustTalk": 
                MODERNASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                ModernTalks.SetActive(false);
                TextSatus(true);
                trust.SetActive(true); 
                trustTxt.SetActive(true); 
                currentTxt = "TrustTalk";
                currentSelecetdButton = "ModernA";
                ModernMTxt.CurrentMTxt = "TrustTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "ReligionsTalk": 
                MODERNASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                ModernTalks.SetActive(false);
                TextSatus(true);
                religions.SetActive(true); 
                religionsTxt.SetActive(true); 
                currentTxt = "ReligionsTalk";
                currentSelecetdButton = "ModernA";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "LandTalk": 
                MODERNASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                ModernTalks.SetActive(false);
                TextSatus(true);
                land.SetActive(true); 
                landTxt.SetActive(true); 
                currentTxt = "LandTalk";
                currentSelecetdButton = "ModernA";
                ModernMTxt.CurrentMTxt = "LandTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                                                                   //DIASPORA

                case "IndiaTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                India.SetActive(true); 
                IndiaTxt.SetActive(true); 
                currentTxt = "IndiaTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "SriLankaTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                SriLanka.SetActive(true); 
                SriLankaTxt.SetActive(true); 
                currentTxt = "SriLankaTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MediterraneanTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Mediterranean.SetActive(true); 
                MediterraneanTxt.SetActive(true); 
                currentTxt = "MediterraneanTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "VenezuelaTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Venezuela.SetActive(true); 
                VenezuelaTxt.SetActive(true); 
                currentTxt = "VenezuelaTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "CanadaTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Canada.SetActive(true); 
                CanadaTxt.SetActive(true); 
                currentTxt = "CanadaTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "BritainTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Britain.SetActive(true); 
                BritainTxt.SetActive(true); 
                currentTxt = "BritainTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "ArgentinaTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Argentina.SetActive(true); 
                ArgentinaTxt.SetActive(true); 
                currentTxt = "ArgentinaTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "RussianTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Russian.SetActive(true); 
                RussianTxt.SetActive(true); 
                currentTxt = "RussianTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "BrazilTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Brazil.SetActive(true); 
                BrazilTxt.SetActive(true); 
                currentTxt = "BrazilTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MigrationTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Migration.SetActive(true); 
                MigrationTxt.SetActive(true); 
                currentTxt = "MigrationTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "MigrationTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "RacismTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Racism.SetActive(true); 
                RacismTxt.SetActive(true); 
                currentTxt = "RacismTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "none";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "ColourismTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                Colourism.SetActive(true); 
                ColourismTxt.SetActive(true); 
                currentTxt = "ColourismTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "ColourismTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "BloodPressureTalk": 
                DIASPORAASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                DiasporaTalks.SetActive(false);
                TextSatus(true);
                BloodPressure.SetActive(true); 
                BloodPressureTxt.SetActive(true); 
                currentTxt = "BloodPressureTalk";
                currentSelecetdButton = "TheDiaspora";
                ModernMTxt.CurrentMTxt = "BloodPressureTalk";
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                                                                   //HEROS

                case "RosaTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                Rosa.SetActive(true); 
                RosaTxt.SetActive(true); 
                currentTxt = "RosaTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "none";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "GeorgeFTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                GeorgeF.SetActive(true); 
                GeorgeFTxt.SetActive(true); 
                currentTxt = "GeorgeFTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "GeorgeFTalk";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "FredHamptonTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                FredHampton.SetActive(true); 
                FredHamptonTxt.SetActive(true); 
                currentTxt = "FredHamptonTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "none";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "BreonnaTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                Breonna.SetActive(true); 
                BreonnaTxt.SetActive(true); 
                currentTxt = "BreonnaTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "none";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MalcomeXTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                MalcomeX.SetActive(true); 
                MalcomeXTxt.SetActive(true); 
                currentTxt = "MalcomeXTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "MalcomeXTalk";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MLKTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                MLK.SetActive(true); 
                MLKTxt.SetActive(true); 
                currentTxt = "MLKTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "MLKTalk";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

                case "MandelaTalk": 
                HEROASSETS(false);
                FindObjectOfType<MKafrica>().ButtonsStatus(false);
                EnvironmetTalks.SetActive(false);
                TextSatus(true);
                Mandela.SetActive(true); 
                MandelaTxt.SetActive(true); 
                currentTxt = "MandelaTalk";
                currentSelecetdButton = "MyHeros";
                ModernMTxt.CurrentMTxt = "MandelaTalk";
                FindObjectOfType<ModernMTxt>().BookIcon();
                isTalking = true;
                Invoke("AssetTalk",1);
                break;

            }
        }
        
    }
    }

//COMMON METHODS

    void TextSatus(bool st){
        ActionButtons.SetActive(st);
        BackgroundTexts.SetActive(st);
        MScaleandRotate.Isenabled = st;
        FindObjectOfType<ModernMTxt>().BookIcon();
        stopTalking();
        ConflictTxt.SetActive(false); 
        peopleTxt.SetActive(false); 
        landTxt.SetActive(false); 
        trustTxt.SetActive(false); 
        religionsTxt.SetActive(false); 
        //DIASPORA
        IndiaTxt.SetActive(false);
        SriLankaTxt.SetActive(false);
        MediterraneanTxt.SetActive(false);
        VenezuelaTxt.SetActive(false);
        CanadaTxt.SetActive(false);
        BritainTxt.SetActive(false);
        ArgentinaTxt.SetActive(false);
        RussianTxt.SetActive(false);
        BrazilTxt.SetActive(false);
        MigrationTxt.SetActive(false);
        RacismTxt.SetActive(false);
        ColourismTxt.SetActive(false);
        BloodPressureTxt.SetActive(false);
        //HEROS
        RosaTxt.SetActive(false);
        GeorgeFTxt.SetActive(false);
        FredHamptonTxt.SetActive(false);
        BreonnaTxt.SetActive(false);
        MalcomeXTxt.SetActive(false);
        MLKTxt.SetActive(false);
        MandelaTxt.SetActive(false);
    }

    public void closeIntercativeModel(){
        if(currentSelecetdButton == "ModernA"){
            stopTalking(); 
           ModernAfricaClicked();
        }else if(currentSelecetdButton == "TheDiaspora"){
            stopTalking(); 
            TheDiaspora();
        }else if (currentSelecetdButton == "MyHeros"){
            stopTalking(); 
           TheHeros();
        }

    }


    // public void closeAfriShamb(){
    //     Scramble();
    // }

    void ResetSize(){
    Conflict.transform.localScale =  ConflictPos;
    people.transform.localScale = peoplePos;
    land.transform.localScale = landPos;
    trust.transform.localScale = trustPos;
    religions.transform.localScale = religionsPos;

    //Diaspora
    India.transform.localScale = IndiaPos;
    SriLanka.transform.localScale = SriLankaPos;
    Mediterranean.transform.localScale = MediterraneanPos; 
    Venezuela.transform.localScale = VenezuelaPos;
    Canada.transform.localScale = CanadaPos;
    Britain.transform.localScale = BritainPos;
    Argentina.transform.localScale = ArgentinaPos;
    Russian.transform.localScale = RussianPos;
    Brazil.transform.localScale = BrazilPos;
    Migration.transform.localScale = MigrationPos;
    Racism.transform.localScale = RacismPos;
    Colourism.transform.localScale = ColourismPos;
    BloodPressure.transform.localScale = BloodPressurePos;

    //HEROS
    Rosa.transform.localScale = RosaPos;
    GeorgeF.transform.localScale = GeorgeFPos;
    FredHampton.transform.localScale = FredHamptonPos;
    Breonna.transform.localScale = BreonnaPos;
    MalcomeX.transform.localScale = MalcomeXPos;
    MLK.transform.localScale = MLKPos;
    Mandela.transform.localScale = MandelaPos;
        print("ResetSize");
    }
    

    public void allOff(){ 
        ModernAfrica.SetActive(false);
        Diaspora.SetActive(false);
        Heros.SetActive(false);
        TextSatus(false);
    }

    public void AssetTalk(){
        if(isTalking == true){
    switch(currentTxt)
        {
            //MODERN
            case "ConflictTalk":   
            startTalking("A paper by Fenske and Kala (2014) focuses instead on the consequences of British abolition. The authors argue that abolition increased the incidence of conflict in the areas within Africa affected by the slave trade. Using geo-coded data on conflicts, they show a discontinuous increase after 1807, which occurred both in West Africa, where the slave trade declined, and West-Central and South-East Africa, where the trade increased as a result. They interpret these findings as follows. In West Africa, the decline of the slave trade challenged pre-existing political authorities who defended their interests through violence. In the other regions, enslavement intensified and was often achieved through violent means. The persistent effect of abolition translates in harsher conflict today in the regions where slave exports increased after 1807. In both settings, he finds a negative impact of past slavery on current development (even though this impact is not driven by plantation slavery). ");
            isTalking = false;
            break;

            case "peopleTalk":   
            startTalking("Physical diversiﬁcation was attended by linguistic multiplicity, and research in this area in recent decades has revealed that continental Africa can be divided into four distinct language families, a family being deﬁned as a group of closely related dialects developing from a common ancestor known as the “proto-language.” One of the largest families is known as Afro-Asiatic, encompassing much of the northern half of the continent as well as western Asia. Afro-Asiatic comprises many of the languages of Ethiopia, Eritrea, and the surrounding area, Berber in north Africa, and Hausa in the west; it also includes Hebrew and, rather more relevantly for Africa in recent centuries, Arabic. The Niger– Congo family, with its root in West Africa, embraces much of the southern half of the continent; one of the most important single offshoots is Bantu, and Bantu languages are now spoken across much of tropical Africa. Nilo-Saharan languages are scattered across the Sahara, and some are spoken by other Negroid populations outside the Niger– Congo family, but they are mainly concentrated in the zone between Lake Chad and the Nile. Finally, Khoisan, perhaps the oldest of all the continent’s language groupings, is associated with the pastoralists and nomadic hunter gatherers of southern Africa, notably in the area of the Kalahari. Its distinctive “click” sound, however, is also heard in small pockets in Kenya and Tanzania. In very general terms, Afro-Asiatic, Niger– Congo, and Nilo-Saharan are associated with the spread of settled agriculture, albeit often combined with the keeping of livestock; and the growth and increasing dominance of these languages over a long period of time – millennia in some areas – may reﬂect improved access to food, relative population growth, and thus the marginalization of Khoisan speakers.");
            isTalking = false;
            break;

            case "TrustTalk":   
            startTalking("Nunn and Wantchekon (2011) investigate the link between the slave trades and trust. Given the importance of trust for economic and institutional development, it may well be the case that it is through this channel that the slave trade still exerts its influence today. The hypothesis is that the slave trades may have generated a culture of mistrust, because of the way slaves were captured by other Africans through raids involving neighboring communities, thus breaking the social bonds upon which trust is built. Early in the slave trade, nearly all slaves were taken in large-scale conflicts or raids, which created an environment of extreme insecurity outside of the local community. Unlike most other environments of conflict and insecurity, the slave trade had one unique feature: individuals could partially protect themselves by turning against others within their community. By engaging in trickery, local kidnappings, or other forms of small scale violence, one could exchange slaves (with Europeans, or slave merchants) for guns and iron weapons. ");
            isTalking = false;
            break;

            case "ReligionsTalk":   
            startTalking("Nineteenth-century Islam can now be seen as a way of life which was present in, and transformed, a very large number of societies in fascinatingly different ways . The other world religion present in West Africa, Christianity, has likewise had its nineteenth-century period reassessed with not unsympathetic skill. The three dominant religious categories, though, are indigenous, Christianity, and Islam. The following is a brief overview of each region: Eastern Africa—Predominantly Christian, Middle Africa—A mix of indigenous and Christianity, Northern Africa—Overwhelmingly Sunni Islam, Southern Africa—Predominantly Christian , Western Africa—Mostly Christian and Muslim");
            isTalking = false;
            break;

            case "LandTalk":   
            startTalking("Africa is the second largest continent in the world, and encompasses enormous diversity in terms of geography and climate from the Mediterranean to the Cape of Good Hope. Clearly, this natural diversity cannot be separated from the history of the continent’s inhabitants: environment and human history are indelibly intertwined, and nowhere is this more demonstrable than in Africa, where disease and poor, thin soils have obstructed the growth of human settlement in many regions. The history of Africans is in large part the struggle to adapt to hostile environments.");
            isTalking = false;
            break;

            //DIASPORA
            case "IndiaTalk":   
            startTalking("'The African diaspora', Jayasuriya and Pankhurst insist, 'has very old roots in the Indian Ocean region, therefore, which are not entirely the consequence of the slave trade. Africans came to India as policemen, traders, bureaucrats, clerics, bodyguards, concubines, servants, soldiers and sailors from the 13th century onwards,' or rather the records of their presence became abundant from the thirteenth century. Thus, unlike the historic Atlantic diasporas, the Indian Ocean diasporas comprised both forced and free migrants. The slave trade ebbed and flowed over the centuries, increasing from the sixteenth to the nineteenth centuries following the rise of the Portuguese seaborne empire and the entry of the other European powers, including the French, British and Dutch, but it never reached the levels of the Atlantic slave trade. It has been observed that Islam provided mechanisms for the integration of the slaves, so that 'in Muslim India they were largely free from racial discrimination. They differed from slaves in America and the West Indies, moreover, in that they were not subjected to plantation labor. Many slaves in India entered the personal service of rulers and other politically important personalities.");
            isTalking = false;
            break;

            case "SriLankaTalk":   
            startTalking("Another country that the collection The African Diaspora in the Indian Ocean looks at is Sri Lanka. Jayusiriya notes that Ethiopia had trading contacts with Sri Lanka from the beginning of the fifth century. As in India, the history of the African diaspora in Sri Lanka is complex, involving people who came freely and those who were brought as slaves or soldiers, especially by the Portuguese, Dutch, and British during their successive eras. Unfortunately, Jayusiriya is far more focused on retrieving the cultural retentions of the Kaffirs, as the African diaspora is called (whose numbers apparently peaked during the Dutch era 1658-1796), and the contributions they made to Sri Lankan society in terms of music, language, and material culture, than on the identities and diaspora cultures they constructed.");
            isTalking = false;
            break;

            case "MediterraneanTalk":   
            startTalking("Before the Atlantic slave trade, the most significant African presence in southern Europe was the Moors from northwestern Africa who occupied and ruled much of Spain between the early eighth and the late fifteenth centuries, but they are rarely discussed in diasporic terms, as an African diaspora. Discussions of African diasporas in the Mediterranean world, which are still relatively scanty, tend to focus on 'blacks', that is Negroid peoples in ancient Rome, or in the Mediterranean lands of Islam, where the question has been posed: what happened to all those millions of Africans who were taken there? Hunwick disputes the suggestion that they disappeared because of the high proportion of eunuchs among the males or the high death rates and low birth rate, and suggests that it was due to the high levels of integration and intermarriages.");
            isTalking = false;
            break;

            case "VenezuelaTalk":   
            startTalking("Similar attempts are being made to demystify Africa’s absence in the histories of other countries in America's southern cone: Bolivia, Paraguay, Uruguay and Venezuela, where the African diaspora is particularly oppressed and marginalized. In some of these countries there are also close relations between the African diaspora and the indigenous communities. The African diaspora also tends to be invisible in the mainstream histories of the US's immediate neighbours to the south and north, Mexico and Canada. In Mexico, the African diaspora found itself negotiating between the large Indian population and the Spanish colonizers.");
            isTalking = false;
            break;

            case "CanadaTalk":   
            startTalking("Until recently, Canadian histories were dominated by the enduring Anglo-French solitudes, which frame national conversation as much as the Black-White divide structures the US national discourse, despite the presence of other racial groups and minorities. In the 1970s two landmark texts, Blacks in Canada: A history by Robin Winks and Black Loyalists by James Walker began to explode the silence by chronicling the histories of the various waves of Africans in Canada, from the early slaves (yes, Canada had slavery) to the loyalists who came in the aftermath of the American War of Independence, to the American slaves escaping north on the underground railroad, the itinerant sailors, the postwar migrants from the Caribbean and the postcolonial migrants from Africa.");
            isTalking = false;
            break;

            case "BritainTalk":   
            startTalking("The African presence in Britain is much better known today than thirty years ago when researchers began to challenge British historians who were, to quote Folarin Shyllon's indictment, 'busy extolling the virtue of their country in abolishing a commerce it had perfected'. While the history of Africans in Britain goes back to Roman times, during the era of the Atlantic slave trade Africans came either from the diaspora or directly from the continent; some were free, but many more were slaves until slavery was abolished. Out of these waves emerged a black British culture with its own associational life, expressive cultural practices, literature and political idioms, all forged in the crucible of unrelenting racial violence and oppression .");
            isTalking = false;
            break;

            case "ArgentinaTalk":   
            startTalking("In societies that have tried to 'whiten' themselves, such as Argentina, the object has been to demonstrate the African demographic presence. It is not widely known that, by 1810, 30 percent of Argentina's and Buenos Aires's population was Afro-Argentinian, and that this was a vibrant community. By 1887 official documents claimed the population had declined to 1.8 percent. The alleged 'disappearance' of Afro-Argentinians was the product of both demographic cleansing - wars, disease, misce- genation, and European immigration - and ideological cleansing - the deliberate 'whitening' of the country's history and image, which included 'the misleading use of government statistics.");
            isTalking = false;
            break;

            case "RussianTalk":   
            startTalking("The literature on Africans in the lands beyond the Mediterranean littoral in pre-modern times appears to be even more sparse. Against this background, there is the captivating account by Allison Blakely, Russia and the Negro: Blacks in Russian history and thought. The origins of the scattered African communities on the Black Sea coast of the Caucasus Mountains are in dispute. Some argue that they were brought there between the sixteenth and nineteenth centuries as slaves for the Turkish and Abkhazian rulers, while others trace their origins many centuries earlier as remnants of an Egyptian army that invaded the region in antiquity. Blakely believes the two explanations may not be necessarily contradictory, in that there were probably different waves of Africans. If the limited quantity and quality of information poses the main challenge in reconstructing the histories of African diasporas in the Indian Ocean and the Mediterranean worlds, in the Atlantic world it is the sheer volume that is daunting");
            isTalking = false;
            break;

            case "BrazilTalk":   
            startTalking("In addition, cultural diversity abounds in the descendants of the African Diaspora as exemplified by Brazilians. With over 4 million slaves, Brazil has long been a melting pot of ancestries and cultures, as evidenced by the blending of African and European religions (Candomble, Catholicism), foods (Feijoada), music, and dance (Samba). A recent census indicates that about 50% of the ~200 million Brazilians self-identify as persons of African ancestry or mixed ancestry. Recent estimates range from 87% in African Caribbeans from Barbados, 75% in African Americans in Southwest USA, 19% in Puerto Ricans, 12% in Colombians in Medellín, 7% in people with Mexican ancestry in Los Angeles, and 4% in both Peruvians in Lima and Argentinians sampled from across Argentina. African ancestry in the Caribbean appears consistent with two waves, the first from Western Africa followed by the second from West-Central Africa. In Spanish-speaking South America, African ancestry averages 5%. In Brazil, African ancestry varies from 51% in Salvador in the Northeast to 15% in Bambuí in the Southeast and 16% in Pelotas in the South. Western African and West-Central African ancestries are more prevalent in Northeastern Brazil due to a larger proportion of disembarkation from Western and WestCentral Africa in Salvador whereas Eastern African ancestry is more prevalent in the Southeast and South due to a larger proportion of disembarkation from Mozambique in Rio de Janeiro.");
            isTalking = false;
            break;

            case "MigrationTalk":   
            startTalking("The history of people of African descent in the USA as framed by four great migrations. The first was the Middle Passage, which in the course of the sixteenth and seventeenth centuries took people from Africa to North America.  During the first half of the nineteenth century, the Second Middle Passage involved the transportation of one million African American slaves from the Atlantic coastal regions to the plantations in the interior.  The third migratory round, which was no longer forced by voluntary, witnessed the relocation of six million free people of African descent from the rural South to the Northern cities, starting from 1915 with the Great Migration and continuing until the 1970s. Lastly, between the end of the twentieth and the beginning of the twenty-first centuries, new Global Passages of migrants of African descent arrived in the USA from the regions that had hosted the previous out-of-Africa coerced diasporas, i.e., the Caribbean, Latin America, Africa, and Europe.");
            isTalking = false;
            break;

            case "RacismTalk":   
            startTalking("Racism is society's impulse to defend itself against itself, against its undesirable elements. The abnormal life is under constant threat, as power wages a permanent war on the very existence of the abnormal. Race diverges from gender and sexuality due to its specific historical development. Race as a discourse emerged with the rise of European modernity and with European encounters with peoples in Africa, Asia, and the Americas. Although European modernity, conquest, and colonization constructed race as a meaningful category distinct from gender and sexuality, the racialization of non-Europeans included gendered and sexualized discourses. Asians, for example, were racially constructed as effeminate; Africans as hypersexual. Meanwhile, distinct discourses of gender and sexuality developed that involved racialized discourses: femininity for white women differed from femininity for black women. As Europe expanded its reach to all corners of the globe, it began to order and classify the spaces and peoples it encountered. The Europeans' ordering and classification were informed by ideals derived from classical antiquity, which privileged European forms over non-European forms, white bodies over dark bodies. Thus, biopolitical violence became racist, as opposed to gendered or sexualized, when whiteness was the standard for valuing bodies and when white bodies were affirmed while non-white bodies were abandoned. ");
            isTalking = false;
            break;

            case "ColourismTalk":   
            startTalking("Colourism is a “system” that grants advantages and opportunities to those that possess lighter complexions within the African-American community. Divergently, skin colour stratification preserves racial categories, namely, the classification of human skin tones that results in differential treatment based on lightness or darkness. Nevertheless, colourism is directly related to skin colour stratification, which both function as a product of racism. Skin colour stratification is a bias controlled by whites that results in positive or negative behaviour toward African Americans (and other people of colour) based on skin tone. African Americans with light complexions have been historically and presently favoured over those who are dark. This stratification based on skin complexion originated with the enslavement of Africans by Europeans. Referred to as “White supremacy ideology,” Hill explains that the institution of slavery was justified by a belief system that marked whiteness as superior to all. Thus, blackness was a sign of shame, immorality, and unpleasantness. The word black is attributed to unpleasant representations. Fanon suggested that persons of African descent attempt to break away from opposing identifiers by bearing a white mask. This mask can take many forms. As reviewed, it may be physically imitating white women in appearance, or as Fanon puts forth, perfecting the language of the oppressor. In all, it is the acceptance of the dominant group’s cultural values. This acceptance creates a “self-division” for African Americans, both mentally and physically");
            isTalking = false;
            break;

            case "BloodPressureTalk":   
            startTalking("The prevalence of high blood pressure (BP; systolic BP [SBP]1 of 140 mm Hg or greater or diastolic BP [DBP] of 90 mm Hg or greater) in African Americans in the United States is among the highest in the world.  With respect to perceived racism, the chronic stress associated with exposure to racial discrimination has been proposed to contribute to African Americans’ higher risk for hypertension. 35.8% of Black men and 42.0% of Black women are affected by hypertension. Given that 40% of African Americans have high BP compared with 27% of Whites in this country. Thirty percent of all deaths of Black men and 20% of all deaths of Black women may be attributable to hypertension.");
            isTalking = false;
            break;

            //HEROS 

            case "RosaTalk":   
            startTalking("Rosa Parks (1913—2005) helped initiate the civil rights movement in the United States when she refused to give up her seat to a white man on a Montgomery, Alabama bus in 1955. Her actions inspired the leaders of the local Black community to organize the Montgomery Bus Boycott. Led by a young Rev. Dr. Martin Luther King Jr., the boycott lasted more than a year—during which Parks not coincidentally lost her job—and ended only when the U.S. Supreme Court ruled that bus segregation was unconstitutional. Over the next half-century, Parks became a nationally recognized symbol of dignity and strength in the struggle to end entrenched racial segregation.");
            isTalking = false;
            break;

            case "GeorgeFTalk":   
            startTalking("On May 25, 2020, George Floyd died while in the custody of four officers of Minnesota's Minneapolis Police Department. One of the officers had knelt on Floyd's neck for nearly ten minutes. Floyd's death caused a wave of protests across the United States and around the world calling for an end to police violence. ");
            isTalking = false;
            break;

            case "FredHamptonTalk":   
            startTalking("Fred Hampton was born in Chicago on 30th August 1948 and grew up in Maywood, a suburb of the city. A bright student, Hampton graduated from Proviso East High School in 1966 before enrolling at Triton Junior College where he studied law.In November 1968, Fred Hampton joined Illinois’ nascent arm of the Black Panther Party. A year later, following Hampton’s meteoric rise as a political organizer with revolution on his mind, he was dead in December 1969 at just 21 years old, shot twice in the head by FBI raiders while sleeping next to his pregnant fiancee in their Chicago apartment. ");
            isTalking = false;
            break;

            case "BreonnaTalk":   
            startTalking("The killing of Breonna Taylor, a 26-year-old black woman who was shot in her Louisville home by US police in March - has resonated around the world, with protesters demanding that the public say her name.  On 23 September, one officer - Brett Hankison - was charged, not with Ms Taylor's death but with wanton endangerment for firing into a neighbour's apartment. Two other officers who were involved have not been charged. Ben Crump, lawyer from the Taylor family, said the fact that no charges had been brought in direct relation to the killing was outrageous and offensive.");
            isTalking = false;
            break;

            case "MalcomeXTalk":   
            startTalking("Malcolm X was an African American leader in the civil rights movement, minister and supporter of Black nationalism. He urged his fellow Black Americans to protect themselves against white aggression “by any means necessary,” a stance that often put him at odds with the nonviolent teachings of Martin Luther King, Jr. His charisma and oratory skills helped him achieve national prominence in the Nation of Islam, a belief system that merged Islam with Black nationalism. After Malcolm X’s assassination in 1965, his bestselling book, The Autobiography of Malcolm X, popularized his ideas and inspired the Black Power movement.");
            isTalking = false;
            break;

            case "MLKTalk":   
            startTalking("Martin Luther King, Jr. was a social activist and Baptist minister who played a key role in the American civil rights movement from the mid-1950s until his assassination in 1968. King sought equality and human rights for African Americans, the economically disadvantaged and all victims of injustice through peaceful protest. He was the driving force behind watershed events such as the Montgomery Bus Boycott and the 1963 March on Washington, which helped bring about such landmark legislation as the Civil Rights Act and the Voting Rights Act. King was awarded the Nobel Peace Prize in 1964 and is remembered each year on Martin Luther King, Jr. Day, a U.S. federal holiday since 1986.");
            isTalking = false;
            break;

            case "MandelaTalk":   
            startTalking("The South African activist and former president Nelson Mandela (1918-2013) helped bring an end to apartheid and has been a global advocate for human rights. A member of the African National Congress party beginning in the 1940s, he was a leader of both peaceful protests and armed resistance against the white minority’s oppressive regime in a racially divided South Africa. His actions landed him in prison for nearly three decades and made him the face of the antiapartheid movement both within his country and internationally. Released in 1990, he participated in the eradication of apartheid and in 1994 became the first black president of South Africa, forming a multiethnic government to oversee the country’s transition. After retiring from politics in 1999, he remained a devoted champion for peace and social justice in his own nation and around the world until his death in 2013 at the age of 95.");
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


 

   ///MODERN SELECTED

    public void ModernAfricaClicked(){
        FindObjectOfType<MKafrica>().ButtonsStatus(true);
        FindObjectOfType<ModernMTxt>().BookIcon();
        allOff();
        ResetSize();
        ModernAfrica.SetActive(true);
        MODERNASSETS(true);
        ModernTalks.SetActive(true);
        currentSelecetdButton = "none";
        stopTalking();
    }

   void MODERNASSETS(bool stat){
        Africa.SetActive(stat);
        Conflict.SetActive(stat);
        people.SetActive(stat);
        land.SetActive(stat);
        trust.SetActive(stat);
        religions.SetActive(stat);

    }

//Diaspora SELECTED
    public void TheDiaspora(){
        stopTalking();
        FindObjectOfType<MKafrica>().ButtonsStatus(true);
        FindObjectOfType<ModernMTxt>().BookIcon();
        allOff();
        ResetSize();
        Diaspora.SetActive(true);
        DIASPORAASSETS(true);
        DiasporaTalks.SetActive(true);
        currentSelecetdButton = "none";
        stopTalking();
    }

 
    void DIASPORAASSETS(bool stat){
   
        India.SetActive(stat);
        SriLanka.SetActive(stat);
        Mediterranean.SetActive(stat);
        Venezuela.SetActive(stat);
        Canada.SetActive(stat);
        Britain.SetActive(stat);
        Argentina.SetActive(stat);
        Russian.SetActive(stat);
        Brazil.SetActive(stat);
        Migration.SetActive(stat);
        Racism.SetActive(stat);
        Colourism.SetActive(stat);
        BloodPressure.SetActive(stat);

    }


    //HEROS SELECTED
    public void TheHeros(){
        stopTalking();
        FindObjectOfType<MKafrica>().ButtonsStatus(true);
        FindObjectOfType<ModernMTxt>().BookIcon();
        allOff();
        ResetSize();
        Heros.SetActive(true);
        HEROASSETS(true);
        EnvironmetTalks.SetActive(true);
        currentSelecetdButton = "none";
        stopTalking();
    }

    void HEROASSETS(bool stat){
        Rosa.SetActive(stat);
        GeorgeF.SetActive(stat);
        FredHampton.SetActive(stat);
        Breonna.SetActive(stat);
        MalcomeX.SetActive(stat);
        MLK.SetActive(stat);
        Mandela.SetActive(stat);      
    }
    


}
