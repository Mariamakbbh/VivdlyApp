using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atlantic : MonoBehaviour
{
   public GameObject BackgroundTexts, talkAsset;
   //Assets / 3D MODELS
    public GameObject AfricaName, GoldCoast, GoldCoastBoat, Masjid, Jesus, Mask, King, Port, LatinA, Triangle, Portugese, WithdrawalCost, BritishAbolish, WithdrawalCostWait;  
    //learn more TEXT
    public GameObject AfricaNameText, GoldCoastText, GoldCoastBoatText, MasjidText, JesusText, MaskText, KingText, LatinAText, TriangleText, PortugeseText, WithdrawalCostText, BritishAbolishText, WithdrawalCostWaitText;
    //REST POS
    Vector3 AfricaNamePos, GoldCoastPos, GoldCoastBoatPos, MasjidPos, JesusPos, MaskPos, KingPos, LatinAPos, TrianglePos, PortugesePos, WithdrawalCostPos, BritishAbolishPos, WithdrawalCostWaitPos;

    //Port ISLAND 
    public GameObject IslandClicked, IslandClose, QandA, Island, Fight, InsideShip, SeeInShip, WalkJourney, Abuse, Drown;
    //port TEXT
    public GameObject IslandPopupBackground, IslandText, FightText, InsideShipText, WalkJourneyText, AbuseText, DrownText;
    //Reset SIZE
    Vector3 IslandPos, Fightpos, InsideShipPos, WalkJourneyPos, AbusePos, DrownPos;

    //GENERAL
    public GameObject ActionButtons, OmouSong;  
    string objName;
    bool isTalking, IntObOn, MusicOff, canSee; 
    public static string currentTxt;
    

    void Start()
    {
      IslandClicked.SetActive(false);
      IslandClose.SetActive(false);
      AfricaNamePos = AfricaName.transform.localScale;
      GoldCoastPos = GoldCoast.transform.localScale;
      GoldCoastBoatPos = GoldCoastBoat.transform.localScale;
      MasjidPos = Masjid.transform.localScale;
      JesusPos = Jesus.transform.localScale;
      MaskPos = Mask.transform.localScale;
      KingPos = King.transform.localScale;
      LatinAPos = LatinA.transform.localScale;
      TrianglePos = Triangle.transform.localScale;
      PortugesePos = Portugese.transform.localScale;
      WithdrawalCostPos = WithdrawalCost.transform.localScale;
      BritishAbolishPos = BritishAbolish.transform.localScale;
      WithdrawalCostWaitPos = WithdrawalCostWait.transform.localScale;

      //island
      IslandPos = Island.transform.localScale;
      Fightpos = Fight.transform.localScale;
      InsideShipPos = InsideShip.transform.localScale;
      WalkJourneyPos = WalkJourney.transform.localScale;
      AbusePos = Abuse.transform.localScale;
      DrownPos = Drown.transform.localScale;
    }

    void Update()
    {
    if(MarkerStates.activeAT == true){  
        MarkerStates.atactive = true;
        MarkerStates.currentScreen = "atlan";
        if(IntObOn == false && !AfricaName.activeSelf && !GoldCoast.activeSelf && !GoldCoastBoat.activeSelf && !talkAsset.activeSelf){
            IntercativeFalse();  
        }
        if(MusicOff == true){
            playUNmuteSondNow();
            MusicOff = false;
        }

       if(MarkerStates.destroyitemsnow == true){
           Invoke("destoryingnow",1);
           MarkerStates.destroyitemsnow = false;
        }

    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;
            switch (objName)
            {
                case "AfricaNameTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "AfricaNameTalk";
                switchInteractive("AfricaNameTalk");
                AtlanticMInfo.CurrentMTxt = "AfricaNameTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "GoldCoastTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "GoldCoastTalk";
                switchInteractive("GoldCoastTalk");
                AtlanticMInfo.CurrentMTxt = "GoldCoastTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "GoldCoastBoatTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "GoldCoastBoatTalk";
                switchInteractive("GoldCoastBoatTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "MasjidTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "MasjidTalk";
                switchInteractive("MasjidTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "JesusTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "JesusTalk";
                switchInteractive("JesusTalk");
                AtlanticMInfo.CurrentMTxt = "JesusTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "MasksTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "MasksTalk";
                switchInteractive("MasksTalk");
                AtlanticMInfo.CurrentMTxt = "MasksTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "KingTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "KingTalk";
                switchInteractive("KingTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "LatinATalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "LatinATalk";
                switchInteractive("LatinATalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 

                case "TriangleTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "TriangleTalk";
                switchInteractive("TriangleTalk");
                AtlanticMInfo.CurrentMTxt = "TriangleTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 

                case "PortugeseTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "PortugeseTalk";
                switchInteractive("PortugeseTalk");
                AtlanticMInfo.CurrentMTxt = "PortugeseTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 

                case "WithdrawalCostTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "WithdrawalCostTalk";
                switchInteractive("WithdrawalCostTalk");
                AtlanticMInfo.CurrentMTxt = "WithdrawalCostTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 

                case "BritishAbolishTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "BritishAbolishTalk";
                switchInteractive("BritishAbolishTalk");
                AtlanticMInfo.CurrentMTxt = "BritishAbolishTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 

                case "WithdrawalCostWaitTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "WithdrawalCostWaitTalk";
                switchInteractive("WithdrawalCostWaitTalk");
                AtlanticMInfo.CurrentMTxt = "WithdrawalCostWaitTalk";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break; 
                
                case "PortTalk": 
                IntObOn = true;
                AllFalse(); 
                currentTxt = "IslandTalk";
                talkAsset.SetActive(false); 
                AllAssetStatus(false);
                IslandClicked.SetActive(true);
                IslandClose.SetActive(true);
                AllTextISLANDStatus(true);
                QandA.SetActive(true); 
                AllAssetISLANDStatus(true);
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;
                                                                //! ISLAND
                

                case "IslandTalk": 
                IntObOn = true;
                currentTxt = "IslandTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("IslandTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "WalkJourneyTalk": 
                IntObOn = true;
                currentTxt = "WalkJourneyTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("WalkJourneyTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "InsideShipTalk": 
                IntObOn = true;
                currentTxt = "InsideShipTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("InsideShipTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                canSee = true;
                Invoke("TalkModel",1);
                break;

                case "FightTalk": 
                IntObOn = true; 
                currentTxt = "FightTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("FightTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "AbuseTalk": 
                IntObOn = true;
                currentTxt = "AbuseTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("AbuseTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                case "DrownTalk": 
                IntObOn = true;
                currentTxt = "DrownTalk";
                IslandPopupBackground.SetActive(false);
                switchInteractive("DrownTalk");
                AtlanticMInfo.CurrentMTxt = "none";
                FindObjectOfType<AtlanticMInfo>().BookIcon();
                Invoke("TalkModel",1);
                break;

                default: 
                break;

            }

        }
    }
    } 
    }

    public void destoryingnow(){
        FindObjectOfType<MarkerStates>().destroySaha();
    }
    public void AtlanticFalse(){
        AllFalse(); //close all texts
        IntercativeFalse(); //turn on 3D models
        FindObjectOfType<GhanaSounds>().StopSound("Omou");
        AtlanticMInfo.CurrentMTxt = "none";
        IntObOn = false;
    }

    public void closeInteractiveModel(){ 
        AllFalse(); //close all texts
        IntercativeFalse(); //turn on 3D models
        ResetSize(); //reset all size to original 
        stopTalking();
        FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Omou");
        AtlanticMInfo.CurrentMTxt = "none";
        MusicOff = true;
        IntObOn = false; 
        canSee = false; 
        SeeInsdeShip();  

    }

    public void closeIslandText(){
        AllTextISLANDStatus(false);
        FindObjectOfType<AtlanticMInfo>().closemtext(); 
        stopTalking();
        AtlanticMInfo.CurrentMTxt = "none";
        FindObjectOfType<AtlanticMInfo>().BookIcon();
        ResetISland();
        currentTxt = "IslandTalk";
        QandA.SetActive(true); 
        canSee = false; 
        SeeInsdeShip();  
        AllAssetISLANDStatus(true);
        IslandPopupBackground.SetActive(false);
    }

    void AllFalse(){ 
        BackgroundTexts.SetActive(false); 
        IslandPopupBackground.SetActive(false);
        AllTextStatus(false);
        AllAssetISLANDStatus(false);
        AllTextISLANDStatus(false);
        ActionButtons.SetActive(false); 
        AtlanticScaleANDRotate.Isenabled = false;
        //FindObjectOfType<GhanaSounds>().MuteSound("Omou");
        OmouSong.SetActive(false); 
        FindObjectOfType<AtlanticMInfo>().closemtext(); 
        ResetSize();

        
    }

//turn On All 3D MODELS 
    void IntercativeFalse(){
        AllAssetStatus(true);
        IslandClicked.SetActive(false);
        IslandClose.SetActive(false);
        //turn on talk ? icon 
        talkAsset.SetActive(true);
    }

//Manage All 3D MODELS (Turn ON + Off)

    void AllAssetStatus(bool setAs){
        AfricaName.SetActive(setAs);
        GoldCoast.SetActive(setAs);
        GoldCoastBoat.SetActive(setAs);
        Masjid.SetActive(setAs);
        Jesus.SetActive(setAs);
        Mask.SetActive(setAs);
        King.SetActive(setAs);
        Port.SetActive(setAs);
        LatinA.SetActive(setAs);
        Triangle.SetActive(setAs);
        Portugese.SetActive(setAs);
        WithdrawalCost.SetActive(setAs);
        BritishAbolish.SetActive(setAs);
        WithdrawalCostWait.SetActive(setAs);

    } 

    void AllAssetISLANDStatus(bool setAs){
        Island.SetActive(setAs);
        Fight.SetActive(setAs);
        InsideShip.SetActive(setAs);
        WalkJourney.SetActive(setAs);
        Abuse.SetActive(setAs);
        Drown.SetActive(setAs);
    }
//Manage All TEXT (Turn ON + Off)
    void AllTextStatus(bool setTAs){
        AfricaNameText.SetActive(setTAs);
        GoldCoastText.SetActive(setTAs);
        GoldCoastBoatText.SetActive(setTAs);
        MasjidText.SetActive(setTAs);
        JesusText.SetActive(setTAs);
        MaskText.SetActive(setTAs);
        KingText.SetActive(setTAs);
        LatinAText.SetActive(setTAs);         
        TriangleText.SetActive(setTAs);
        PortugeseText.SetActive(setTAs);
        WithdrawalCostText.SetActive(setTAs);
        BritishAbolishText.SetActive(setTAs);
        WithdrawalCostWaitText.SetActive(setTAs);
    }

    void AllTextISLANDStatus(bool setTAs){
        IslandText.SetActive(setTAs);
        FightText.SetActive(setTAs);
        InsideShipText.SetActive(setTAs);
        WalkJourneyText.SetActive(setTAs);
        AbuseText.SetActive(setTAs);
        DrownText.SetActive(setTAs);
    }

    void switchInteractive(string WhichOne){
        FindObjectOfType<GhanaSounds>().MuteSound("Omou");
        AtlanticScaleANDRotate.Isenabled = true;
        isTalking = true;
        AllTextISLANDStatus(false);
        AllAssetISLANDStatus(false);
        ActionButtons.SetActive(true); 
        BackgroundTexts.SetActive(true);
        talkAsset.SetActive(false); 
        QandA.SetActive(false); 
        AllAssetStatus(false);
        switch (WhichOne)
            {
                case "AfricaNameTalk": 
                AtlanticMInfo.CurrentMTxt = "AfricaNameTalk";
                AfricaNameText.SetActive(true); 
                AfricaName.SetActive(true); 
                break;

                case "GoldCoastTalk": 
                AtlanticMInfo.CurrentMTxt = "GoldCoastTalk";
                GoldCoastText.SetActive(true); 
                GoldCoast.SetActive(true);  
                break;

                case "GoldCoastBoatTalk": 
                AtlanticMInfo.CurrentMTxt = "none";
                GoldCoastBoatText.SetActive(true); 
                GoldCoastBoat.SetActive(true); 
                GoldCoastBoat.transform.localScale = new Vector3(0.06f,0.06f,0.06f);
                break;

                case "MasjidTalk": 
                AtlanticMInfo.CurrentMTxt = "none";
                MasjidText.SetActive(true); 
                Masjid.SetActive(true); 
                break;

                case "JesusTalk": 
                AtlanticMInfo.CurrentMTxt = "JesusTalk";
                JesusText.SetActive(true); 
                Jesus.SetActive(true); 
                break;

                case "MasksTalk": 
                AtlanticMInfo.CurrentMTxt = "MasksTalk";
                MaskText.SetActive(true); 
                Mask.SetActive(true); 
                break;

                case "KingTalk": 
                AtlanticMInfo.CurrentMTxt = "none";
                KingText.SetActive(true); 
                King.SetActive(true); 
                GoldCoastBoat.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
                break;

                case "LatinATalk": 
                AtlanticMInfo.CurrentMTxt = "none";
                LatinAText.SetActive(true); 
                LatinA.SetActive(true); 
                break; 

                case "TriangleTalk": 
                AtlanticMInfo.CurrentMTxt = "TriangleTalk";
                TriangleText.SetActive(true); 
                Triangle.SetActive(true); 
                break; 

                case "PortugeseTalk": 
                AtlanticMInfo.CurrentMTxt = "PortugeseTalk";
                Portugese.SetActive(true); 
                PortugeseText.SetActive(true); 
                break;

                case "WithdrawalCostTalk": 
                AtlanticMInfo.CurrentMTxt = "WithdrawalCostTalk";
                WithdrawalCost.SetActive(true); 
                WithdrawalCostText.SetActive(true); 
                break;

                case "BritishAbolishTalk": 
                AtlanticMInfo.CurrentMTxt = "BritishAbolishTalk";
                BritishAbolish.SetActive(true); 
                BritishAbolishText.SetActive(true); 
                break;

                case "WithdrawalCostWaitTalk": 
                AtlanticMInfo.CurrentMTxt = "WithdrawalCostWaitTalk";
                WithdrawalCostWait.SetActive(true); 
                WithdrawalCostWaitText.SetActive(true); 
                break; 

                //ISLAND 
                case "IslandTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                IslandText.SetActive(true);
                Island.SetActive(true);
                break;

                case "WalkJourneyTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                WalkJourneyText.SetActive(true);
                WalkJourney.SetActive(true);
                WalkJourney.transform.localScale = new Vector3(2f,2f,2f);
                break;

                case "InsideShipTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                InsideShipText.SetActive(true);
                InsideShip.SetActive(true);
                InsideShip.transform.localScale = new Vector3(0.4f,0.4f,0.4f);
                break;

                case "FightTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                Fight.SetActive(true);
                FightText.SetActive(true); 
                break;

                case "AbuseTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                Abuse.SetActive(true);
                AbuseText.SetActive(true);
                break;

                case "DrownTalk": 
                BackgroundTexts.SetActive(false);
                AtlanticMInfo.CurrentMTxt = "none";
                IslandPopupBackground.SetActive(true);
                Drown.SetActive(true);
                Drown.transform.localScale = new Vector3(2f,2f,2f);
                DrownText.SetActive(true);
                
                break;


                default:
                break;
            }
    
    }

    void SeeInsdeShip(){
        if(canSee){
            SeeInShip.SetActive(true);
        }else{
            SeeInShip.SetActive(false);
        }
    }

    public void LeaveBelowDeck(){
        canSee = false;
        SeeInsdeShip();
    }

    public void GobelowDeck(){
        if(currentTxt == "InsideShipTalk"){
        canSee = true;
        SeeInsdeShip();
        }else{
            canSee = false;
        }
    }

    public void TalkModel(){
    if(isTalking == true){
    switch(currentTxt)
        {
            case "AfricaNameTalk":   
            startTalking("How was Africa invented? And by whom? The short answer, according to Mudimbe, is that the idea of Africa was initially fashioned not by Africans but by non-Africans, as a ‘paradigm of difference’. Africa, in other words, has served as an exotic prism through which outsiders, mainly Europeans, refracted images of ‘the other’ and of themselves. Before the 20th century, very few of Africa’s inhabitants thought of themselves as ‘Africans’. For the Greeks, the term ‘Libyans’ ( Libyes ) seems to have had a vague racial connotation, as it was used to distinguish the peoples of the Mediterranean coast from darker-skinned ‘Ethiopians’ (from Aithiops , lit. ‘burnt-faced’) to the south. Greek observers divided the Libyans into numerous ‘tribes’, one of which, around the Phoenician outpost of Carthage (in modern Tunisia), later Roman sources refer to as the Afri. Africa, ‘the land of the Afri’, was originally applied in a strictly limited sense to the Roman province created after the conquest of Carthage in 146 BC. Following the demise of the Roman empire and the Arab conquest of North Africa in the 7th century AD, the same coastal region became known, in Arabic, as ‘Ifriqiya’. ");
            isTalking = false;
            break;

            case "GoldCoastTalk":   
            startTalking("The Gold Coast had had a long period of contact with European traders. The first European forts were established soon after the Europeans set foot on the coast, already in the late 15th century, and there had been a continuous European presence on the coast ever since. Contact was initiated by Portuguese explorers, but soon agents from many European nations would be involved in trading on the Gold Coast. From the 17th century, both the Dutch and the English were firmly established. For a long period of time, however, the Gold Coast was privileged compared to many other parts of Western Africa in the sense that exports were primarily centred on what the European name of the region implies: gold. Gold was extracted in several places inland, and was in ubiquitous use as a means of payment on the coast.");
            isTalking = false;
            break;

            case "GoldCoastBoatTalk":   
            startTalking("The median voyage time for the Middle Passage for ships leaving from the Gold Coast was approximately 70 days, but Eltis argues that the ships often provisioned for three months’ needs. The median waiting time off the Gold Coast for the ships included in the Transatlantic Slave Trade Database was a further 109 days (own estimate based on TSTD2 2010). The British in general had around 150 to 200 people stationed on the Gold Coast during the 18th century, while the Dutch had around 200 to 250, and the Danish around 60 people. In total, the number of Europeans stationed on the Gold Coast might thus have amounted to around 500 people. Population estimates from the pre-colonial Gold Coast are very uncertain. What crude estimates there are suggest that the population might have amounted to between 1.3 and 2.3 million people in the year 1850, after possibly having decreased for several centuries as a consequence of the slave trade. ");
            isTalking = false;
            break;

            case "MasjidTalk":   
            startTalking("With the advent of the Portuguese in both the Indian Ocean and off the Atlantic coast, slaving went into overdrive, initially to meet the demands for servile labor in the Mediterranean and islands off the West African coast and subsequently in the Americas after the latter’s “discovery.” Muslim communities in West Africa first organized to protect themselves against slaving but in the process of protection necessarily produced captives, whom they sold.");
            isTalking = false;
            break;

            case "JesusTalk":   
            startTalking("Amongst 19th century pan-Africanists – most of whom believed that Africa’s ‘redemption’ would come through conversion to Christianity.  European incursion brought with it notions of Christianity, which had a major impact on West Central Africa and the kingdom of Kongo. Christianity there had formed a royal cult since the fifteenth century, with adherents throughout the realm, though the extent and quality of their adherence remains a matter of debate, as they clearly continued practices antedating Christianity’s arrival. ");
            isTalking = false;
            break;

            case "MasksTalk":   
            startTalking("Africans also believe in and – as they have been as questioning and contrary as anyone on the planet – have also harboured doubts about a large number of religions. These range from innumerable examples of indigenous belief systems to those like Islam and Christianity, socalled world religions. The latter also come in a variety of forms, some of which constitute distinctive African contributions to the history of those beliefs. There are numerous examples of African innovation in the realm of world religions. Many of them, like the Muslim Murid brotherhood, whose origins lie in early 20th-century Senegal, or the Aladura churches of southwestern Nigeria, have now taken root in the cities of Europe and North America. The continent’s greatest spiritual exports, the vodun and orisha , West African deities who in Brazil and the Caribbean animated ‘voodoo’, santería, candomblé, and other hybrid religions. The ways in which extraordinarily large numbers of Africans have become Christian and Muslim – and the underlying resilience of indigenous beliefs – are increasingly important themes in African historical studies.");
            isTalking = false;
            break;

            case "KingTalk":   
            startTalking("In August 1518, King Charles I authorized Spain to ship enslaved people directly from Africa to the Americas. The edict marked a new phase in the transatlantic slave trade in which the numbers of enslaved people brought directly to the Americas—without going through a European port first—rose dramatically. The transatlantic slave trade didn’t start in 1518, but it did increase after King Charles authorized direct Africa-to-Caribbean trips that year. ");
            isTalking = false;
            break;

            case "LatinATalk":   
            startTalking("The number of slaves embarked from Africa, by broad embarkation regions and by 100-year periods. West-Central Africa represented the main source, with 45 % of the overall volume. Next came Benin (16 %), Biafra (13 %), the Gold Coast (10 %), and Senegambia (6 %). Slavery was already present in Africa before the slave trades and in fact continues, in some parts of the continent, to the present day. Europe experienced slavery as well. The main destination was Brazil (45 %), next came the Caribbean (22 and 10 %, respectively, for the British and French portions) and the Spanish Americas (12 %). Less than 4 % were taken to North America.");
            isTalking = false;
            break;

            case "TriangleTalk":   
            startTalking("The transatlantic slave trade generally followed a triangular route: Traders set out from European ports towards Africa's west coast. There they bought people in exchange for goods and loaded them into the ships. The voyage across the Atlantic, known as the Middle Passage, generally took 6 to 8 weeks. Once in the Americas those Africans who had survived the journey were offloaded for sale and put to work as enslaved labour. The ships then returned to Europe with goods such as sugar, coffee, tobacco, rice and later cotton, which had been produced by enslaved labour.");
            isTalking = false;
            break;

            case "PortugeseTalk":   
            startTalking("The Portuguese voyages of the ‘age of discovery’ not only served to expand European knowledge of Africa, they also initiated a process that would transform European thinking about Africans. The context for this transformation was the transatlantic slave trade. Slavery had been a prominent feature of the classical Mediterranean world and had continued in various forms in medieval Europe. It also existed in the Muslim world, including North Africa, and in sub-Saharan Africa itself. Yet it was the Atlantic slave trade, which between the 16th and the 19th centuries involved the forced migration of some 12 million Africans to the Americas, that forged an explicit link in European minds between racial inferiority, enslavement, and Africa.");
            isTalking = false;
            break;

            case "WithdrawalCostTalk":   
            startTalking("After losing access to  West Africa's more productive slaving zones, around 1740 the Dutch found new markets for slaves on the Windward Coast, where conditions for trade were far less favorable. In most African regions slave trading was concentrated in a limited number of ports, but trade on the Windward Coast was spread out over numerous small embarkation points. Dutch free traders on the coast of West Africa obtained roughly 70 percent of their slave cargoes on the Windward Coast, while the remaining purchases were completed on the Gold Coast. He further estimated that, overall, the Dutch colonies in the Americas drew roughly  40 percent of their slave labor force from the Windward Coast. ");
            isTalking = false;
            break;

            case "BritishAbolishTalk":   
            startTalking("The increasing intervention of Europe into African affairs is apparent in the anti-slave trade campaign. British ships had carried the largest proportion of Africans across the Atlantic in the 18th century, slave-grown Caribbean sugar making a critical contribution to the national economy. After a long campaign by abolitionists, the British parliament finally voted to outlaw the transportation of slaves in British ships, effective from 1 May 1807. It was not the first such legislation: some individual states of the United States had already prohibited the trade, as had Denmark. Revolutionary France, meanwhile, in the aftermath of the huge slave uprising in its Caribbeancolony of Saint Domingue (Haiti) in 1791, had declared an end to the slave trade and to theinstitution of slavery, only for both to be reinstated by Napoleon in 1802. Nor was abolition immediately effective. Africans continued to be exported across the Atlantic in large numbersuntil mid-century, while slavery itself continued in Brazil and Cuba until the 1880s and in many parts of Africa well into the 20th century. Yet for all its ambiguity, 1807 represents a key moment in the making of the modern world.");
            isTalking = false;
            break;

            case "WithdrawalCostWaitTalk":   
            startTalking("On average, the MCC vessels spent 222 days on the Africa coast buying slaves. The average number of slaves carried per voyage was 269, which translates to a purchase rate of 1.2 slaves per day (which was similar to daily loading rates of Liverpool ships trading on the Windward. The MCC data on slave mortality, however, run contrary to expectations. First, the overall death rate of 12.9 percent was low by Dutch standards. TSTD2 indicates that of all slaves shipped by the WIC from West Africa, 16.8 percent had died before sale in the Americas");
            isTalking = false;
            break;
                                             //ISLAND
            case "IslandTalk":   
            startTalking("São Tomé was a colonial island port off the west coast of Africa that Portugal established in the mid-1400s. Before 1518, Portugal forced enslaved Africans to work on islands in the eastern Atlantic. Spanish ships brought captive Africans to the Iberian Peninsula, from which they sent some to the Caribbean. Spain may have increased the number of enslaved Africans it brought to the Caribbean after 1518 because the Native people it had previously enslaved there were dying from European disease and colonial violence. It was considered normal for enslaved people to be black, even though there were enslaved people of other origins. When a slaves dies they’ll send somebody to [record] what the brand was on the slave and what they died of and keep a record, and that’s all again for commercial purposes—they can claim that as loss later on.");
            isTalking = false;
            break;

            case "WalkJourneyTalk":   
            startTalking("Transatlantic slave trade, segment of the global slave trade that transported between 10 million and 12 million enslaved Africans across the Atlantic Ocean to the Americas from the 16th to the 19th century. Africans were marched to the coast, a journey that could be as many as 300 miles (485 km). Typically, two captives were chained together at the ankle, and columns of captives were tied together by ropes around their necks. They were all branded like sheep. These were impressed under their breasts or on their arms. An estimated 10 to 15 percent of the captives died on their way to the coast. ");
            isTalking = false;
            break;

            case "InsideShipTalk":   
            startTalking("Hundreds of Africans were packed tightly into tiers below decks for a voyage of about 5,000 miles (8,000 km). They were typically chained together, and usually the low ceilings did not permit them to sit upright. The heat was intolerable, and the oxygen levels became so low that candles would not burn. The space between decks was divided into two compartments 3 feet 3 inches high; the size of one was 16 feet by 18 and of the other 40 by 21; into the first were crammed the women and girls, into the second the men and boys: 226fellow creatures were thus thrust into one space 288 feet square and 336into another space 800 feet square, giving to the whole an average Of 23inches and to each of the women not more than 13 inches. We also found manacles and fetters of different kinds, but it appears that they had all been taken off before we boarded.");
            isTalking = false;
            break;

            case "FightTalk":   
            startTalking("Occasionally, the African captives successfully revolted and took over the ships. The most-famous such incident occurred when in 1839 a slave named Joseph Cinqué led a mutiny of 53 illegally purchased slaves on the Spanish slave ship Amistad, killing the captain and two members of the crew. The U.S. Supreme Court eventually ordered the Africans to be returned to their homes.");
            isTalking = false;
            break;

            case "AbuseTalk":   
            startTalking("Africans were allowed to go outside on the upper decks for only a few hours each day. Atrocities and sexual abuse of the enslaved captives were widespread, although their monetary value as slaves perhaps mitigated such treatment. ");
            isTalking = false;
            break;

            case "DrownTalk":   
            startTalking("Men, women and children crammed into every available space, denied adequate room, food or breathing space. The  stench  was  appalling  -  the  atmosphere  inhumane  to say  the  least. Between 15 and 25 percent of the African slaves bound for the Americas died aboard the slave ship. An infamous incident of the slave ship Zong in 1781, when both Africans and crew members were dying of an infectious disease, Capt. Luke Collingwood, hoping to stop the disease, ordered that more than 130 Africans be thrown overboard.");
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

 void ResetSize(){
        AfricaName.transform.localScale = AfricaNamePos;
        GoldCoast.transform.localScale = GoldCoastPos;
        GoldCoastBoat.transform.localScale = GoldCoastBoatPos;
        Masjid.transform.localScale = MasjidPos;
        Jesus.transform.localScale = JesusPos;
        Mask.transform.localScale = MaskPos;
        King.transform.localScale = KingPos;
        LatinA.transform.localScale = LatinAPos;
        Triangle.transform.localScale = TrianglePos;
        Portugese.transform.localScale = PortugesePos;
        WithdrawalCost.transform.localScale = WithdrawalCostPos;
        BritishAbolish.transform.localScale = BritishAbolishPos;
        WithdrawalCostWait.transform.localScale = WithdrawalCostWaitPos;
        ResetISland();
        
    }

void ResetISland(){
   Island.transform.localScale = IslandPos;
   Fight.transform.localScale  = Fightpos;
   InsideShip.transform.localScale  = InsideShipPos;
   WalkJourney.transform.localScale = WalkJourneyPos;
    Abuse.transform.localScale =  AbusePos;
    Drown.transform.localScale =  DrownPos;
}


    //speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }

  public void playSondNow(){
    FindObjectOfType<GhanaSounds>().PlaySound("Omou");
    OmouSong.SetActive(true); 
  }

  public void playUNmuteSondNow(){
    FindObjectOfType<GhanaSounds>().Unmute("Omou");
    OmouSong.SetActive(true); 
  }


  public void GoToOmouSong(){
      Application.OpenURL("https://www.youtube.com/watch?v=11gCg1l1c8g");
  }


}
