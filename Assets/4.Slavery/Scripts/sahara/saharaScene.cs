using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saharaScene : MonoBehaviour
{
    public GameObject SubSaharan_Sahara, SubSaharan_Sudan, SubSaharan_North, Intro;
    string objName;
    public GameObject CloseSahaExp;
    bool saharaScreen, sudanScreen, NorthScreen, closeN, closeS;
    //action objects 
    public GameObject ActionButtons;  
    public GameObject BackgroundTexts, PrayerText, SaharaText, SlaveAmountText, CaravanText, NonInteractive;
    public GameObject PrayerInteractive, SaharaInteractive, SlaveInteractive, CaravanInteractive, pane_buttonsGone;
    //NOrth Africa
    public GameObject WhiteSlaveInteractive, BlackSlaveInteractive, WomenSlaveInteractive, QuranInteractive, MomInteractive, LeavingInteractive, DeadInteractive, NonMuslimInteractive, NonInteractiveNORTH;
    public GameObject WhiteSlaveText, BlackSlaveText, WomenSlaveText, QuranText, MomText, LeavingText, DeadText, NonMuslimText;
    //SUDAN
    public GameObject MediterInteractive, KidnapInteractive, GoldInteractive, TradeInteractive, Qs;
    public GameObject MediterText, KidnapText, GoldText, TradeText;

    bool isTalking;
    public static string currentTxt;
    Vector3 PrayerStartPos, SaharaStartPos, SlaveStartPos, CaravanStartPos, medi, kidn, fold, trade;
    Quaternion PrayerStartRo, SaharaStartRo, SlaveStartRo, CaravanStartRo;
    // Start is called before the first frame update
    void Start()
    {
      SubSaharan_Sahara.SetActive(false);  
      SubSaharan_Sudan.SetActive(false); 
      SubSaharan_North.SetActive(false); 
                                                //Sahara
      //original Positiion
      PrayerStartPos = PrayerInteractive.transform.localScale;
      SaharaStartPos = SaharaInteractive.transform.localScale;
      SlaveStartPos = SlaveInteractive.transform.localScale;
      CaravanStartPos = CaravanInteractive.transform.localScale;
      medi = MediterInteractive.transform.localScale;
      kidn = KidnapInteractive.transform.localScale;
      fold = GoldInteractive.transform.localScale;
      trade = TradeInteractive.transform.localScale;

      //original Rotation
      PrayerStartRo = PrayerInteractive.transform.rotation;
      SaharaStartRo = SaharaInteractive.transform.rotation;
      SlaveStartRo = SlaveInteractive.transform.rotation;
      CaravanStartRo = CaravanInteractive.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    if(MarkerStates.activeSahara == true){
        MarkerStates.sahaactive = true;
        MarkerStates.currentScreen = "sahaBtn";
        if(MarkerStates.IntroSahara == true){
            Intro.SetActive(true); 
            MarkerStates.IntroSahara = false;

        FindObjectOfType<MarkerStates>().destroyAt();
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
        } 
        if(SubSaharan_Sahara.activeSelf && !CloseSahaExp.activeSelf && NonInteractive.activeSelf){
            NonInteractive.SetActive(true); 
            CloseBtn();  
            FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sahara");
        }else if(SubSaharan_Sudan.activeSelf && !CloseSahaExp.activeSelf && NonInteractive.activeSelf && closeS == false){
            pane_buttonsGone.SetActive(false);
            CloseBtn(); 
            SudanBack(true);
            FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
        }
        else if(SubSaharan_North.activeSelf && !CloseSahaExp.activeSelf && NonInteractive.activeSelf && closeN == false){
            CloseBtn(); 
            NonInteractiveNORTH.SetActive(true); 
            FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("North");
        }
        if(closeN == true){
        CloseSahaExp.SetActive(false); 
        FindObjectOfType<GhanaSounds>().MuteSound("North");
        }

        if(closeS == true){
            CloseSahaExp.SetActive(false); 
            pane_buttonsGone.SetActive(false);
            FindObjectOfType<GhanaSounds>().MuteSound("Sudan");
        }

    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit)){
            objName = Hit.transform.name;

            switch (objName)
            {
                case "SubSaharan_Sahara": 
                allFalse();
                FindObjectOfType<GhanaSounds>().StopSound("North");
                FindObjectOfType<GhanaSounds>().StopSound("Sudan");
                FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sahara");
                SubSaharan_Sahara.SetActive(true); 
                CloseBtn();
                saharaScreen = true;
                break;

                case "SubSaharan_Sudan": 
                allFalse();
                FindObjectOfType<GhanaSounds>().StopSound("Sahara");
                FindObjectOfType<GhanaSounds>().StopSound("North");
                FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("Sudan");
                SubSaharan_Sudan.SetActive(true); 
                pane_buttonsGone.SetActive(false);
                CloseBtn();
                SudanBack(true);
                sudanScreen = true;
                break;

                case "SubSaharan_North": 
                allFalse();
                FindObjectOfType<GhanaSounds>().StopSound("Sahara");
                FindObjectOfType<GhanaSounds>().StopSound("Sudan");
                FindObjectOfType<GhanaSounds>().PlaySoundifnotPlaying("North");
                SubSaharan_North.SetActive(true); 
                CloseBtn();
                NorthScreen = true;
                break;

                default: 
                break;

            }

            //game objects
                                                                              //SAHARA
            if(saharaScreen == true){
             switch (objName)
             {
                case "PrayerTalk": 
                NonInteractive.SetActive(false); 
                CloseSahaExp.SetActive(false);
                pane_buttonsGone.SetActive(false); 
                closeAllText();
                ActionButtons.SetActive(true);
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                PrayerInteractive.SetActive(true); 
                PrayerText.SetActive(true);  
                isTalking = true;
                currentTxt = "PrayerTalk";
                SaharaMoreInfo.CurrentMTxt = "PrayerTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                CloseSahaExp.SetActive(false); 
                PrayerText.SetActive(true); 
                muteAllMusic();
                TalkModel();
                break;

                case "SlaveAmountTalk": 
                NonInteractive.SetActive(false); 
                CloseSahaExp.SetActive(false);
                pane_buttonsGone.SetActive(false);
                closeAllText();
                ActionButtons.SetActive(true);
                SaharaScaleANDRotate.Isenabled = true; 
                BackgroundTexts.SetActive(true); 
                SlaveAmountText.SetActive(true); 
                SlaveInteractive.SetActive(true);  
                isTalking = true;
                currentTxt = "SlaveAmountTalk";
                SaharaMoreInfo.CurrentMTxt = "SlaveAmountTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                CloseSahaExp.SetActive(false); 
                muteAllMusic();
                TalkModel();
                break;

                case "SaharaTalk": 
                NonInteractive.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                muteAllMusic();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                SaharaText.SetActive(true); 
                SaharaInteractive.SetActive(true);
                isTalking = true;
                currentTxt = "SaharaTalk";
                SaharaMoreInfo.CurrentMTxt = "SaharaTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                CloseSahaExp.SetActive(false); 
                TalkModel();
                break;

                case "CaravanTalk": 
                 NonInteractive.SetActive(false); 
                 pane_buttonsGone.SetActive(false);
                closeAllText();
                muteAllMusic();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                CaravanText.SetActive(true); 
                CaravanInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "CaravanTalk";
                SaharaMoreInfo.CurrentMTxt = "CaravanTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                CloseSahaExp.SetActive(false); 
                TalkModel();
                break;

                default: 
                break;
             }
                                                                              //SUDAN
            }else if (sudanScreen == true){
                switch (objName)
             {
                case "MediterInteractiveTalk":
                SudanBack(false);
                SudanClicked();
                closeAllText();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                MediterText.SetActive(true); 
                MediterInteractive.SetActive(true);
                isTalking = true;
                closeS = true;
                currentTxt = "MediterInteractiveTalk";
                SaharaMoreInfo.CurrentMTxt = "MediterInteractiveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "KidnapInteractiveTalk": 
                SudanBack(false);
                SudanClicked();
                closeAllText();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                KidnapText.SetActive(true); 
                KidnapInteractive.SetActive(true); 
                isTalking = true;
                closeS = true;
                currentTxt = "KidnapInteractiveTalk";
                SaharaMoreInfo.CurrentMTxt = "KidnapInteractiveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "GoldInteractiveTalk": 
                SudanBack(false);
                SudanClicked();
                closeAllText();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                GoldText.SetActive(true); 
                GoldInteractive.SetActive(true); 
                isTalking = true;
                closeS = true;
                currentTxt = "GoldInteractiveTalk";
                SaharaMoreInfo.CurrentMTxt = "GoldInteractiveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "TradeInteractiveTalk": 
                SudanBack(false);
                SudanClicked();
                closeAllText();
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                TradeText.SetActive(true); 
                TradeInteractive.SetActive(true); 
                isTalking = true;
                closeS = true;
                currentTxt = "TradeInteractiveTalk";
                SaharaMoreInfo.CurrentMTxt = "TradeInteractiveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                default: 
                break;
             }
                                                                              //NORTH AFRICA
            }else if(NorthScreen == true){
                switch (objName)
             { 
                case "WhiteSlavesTalk ": 
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true); 
                WhiteSlaveText.SetActive(true); 
                WhiteSlaveInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "WhiteSlavesTalk";
                SaharaMoreInfo.CurrentMTxt = "WhiteSlavesTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "BlackSlaveTalk":
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                BlackSlaveText.SetActive(true); 
                BlackSlaveInteractive.SetActive(true);
                isTalking = true;
                currentTxt = "BlackSlaveTalk";
                SaharaMoreInfo.CurrentMTxt = "BlackSlaveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel(); 
                break;
        
                case "SlaveGirlsTalk": 
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                WomenSlaveText.SetActive(true); 
                WomenSlaveInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "SlaveGirlsTalk";
                SaharaMoreInfo.CurrentMTxt = "SlaveGirlsTalk"; 
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "QuranTalk": 
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                QuranText.SetActive(true);
                QuranInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "QuranTalk";
                SaharaMoreInfo.CurrentMTxt = "QuranTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon(); 
                TalkModel();
                break; 
        
                case "SingleMomTalk": 
                NonInteractiveNORTH.SetActive(false);
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                MomText.SetActive(true); 
                MomInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "SingleMomTalk";
                SaharaMoreInfo.CurrentMTxt = "none";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "SlaveLeaveTalk": 
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                LeavingText.SetActive(true); 
                LeavingInteractive.SetActive(true);
                isTalking = true;
                currentTxt = "SlaveLeaveTalk";
                SaharaMoreInfo.CurrentMTxt = "SlaveLeaveTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "DeadTalk": 
                NonInteractiveNORTH.SetActive(false); 
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                DeadText.SetActive(true); 
                DeadInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "DeadTalk";
                SaharaMoreInfo.CurrentMTxt = "DeadTalk";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                case "NonMuslimTalk": 
                NonInteractiveNORTH.SetActive(false); 
                Invoke("away",1);
                pane_buttonsGone.SetActive(false);
                closeAllText();
                closeN = true;
                ActionButtons.SetActive(true); 
                SaharaScaleANDRotate.Isenabled = true;
                BackgroundTexts.SetActive(true);
                NonMuslimText.SetActive(true); 
                NonMuslimInteractive.SetActive(true); 
                isTalking = true;
                currentTxt = "NonMuslimTalk"; 
                SaharaMoreInfo.CurrentMTxt = "none";
                FindObjectOfType<SaharaMoreInfo>().BookIcon();
                TalkModel();
                break;

                default: 
                break;
             }

            }

        }   

    }
    }

    }

    public void MarkerToOperate(){
        CloseSahaExp.SetActive(false); 
        isTalking = false;
        Intro.SetActive(false); 
        MarkerStates.IntroSahara = false;
        closeAllText();
        SudanBack(false);
        SudanClicked();
        ResetSize();
        pane_buttonsGone.SetActive(true);
        NonInteractive.SetActive(true); 
        NonInteractiveNORTH.SetActive(true); 
        SaharaScaleANDRotate.Isenabled = false;
        closeN = false;
        closeS = false;
        SaharaMoreInfo.CurrentMTxt = "none";
        stopAllMusic();
    }

    void allFalse(){
      SubSaharan_Sahara.SetActive(false);  
      SubSaharan_Sudan.SetActive(false); 
      SubSaharan_North.SetActive(false); 
      saharaScreen = false;
      sudanScreen = false;
      NorthScreen = false;
      closeN = false;
      closeIntro();

    }


    void stopAllMusic(){
        FindObjectOfType<GhanaSounds>().StopSound("Sahara");
        FindObjectOfType<GhanaSounds>().StopSound("North");
        FindObjectOfType<GhanaSounds>().StopSound("Sudan");
    }

    void muteAllMusic(){
        FindObjectOfType<GhanaSounds>().MuteSound("Sahara");
        FindObjectOfType<GhanaSounds>().MuteSound("North");
        FindObjectOfType<GhanaSounds>().MuteSound("Sudan");
    }
    void unmuteAllMusic(){
        FindObjectOfType<GhanaSounds>().Unmute("Sahara");
        FindObjectOfType<GhanaSounds>().Unmute("North");
        FindObjectOfType<GhanaSounds>().Unmute("Sudan");
    }

    void CloseBtn(){
        //close exp
        CloseSahaExp.SetActive(true); 
    }

    public void playSahaIntro(){
      startTalking("The Trans-Saharan Slave Trade is the full-length history of the northbound trade in black slaves across the Sahara to North Africa (Maghreb). It reveals an ancient, persistent but obscure traffic, a basic but largely overlooked feature of the historical economy and society of the Sahara and North Africa. This was one of Africa’s four main slaving outlets. Please click one of the three regions in the map to start your AR experience");
    }

    public void closeIntro(){
      Intro.SetActive(false); 
      MarkerStates.IntroSahara = false;
    }

    public void closeAll(){
    allFalse();
    CloseSahaExp.SetActive(false);
    pane_buttonsGone.SetActive(true); 
    muteAllMusic();
    }

    public void closeAllText(){
        BackgroundTexts.SetActive(false); 

                                                 //SAHARA
        //paryer
        PrayerText.SetActive(false); 
        PrayerInteractive.SetActive(false); 
        //saharaBack
        SaharaText.SetActive(false); 
        SaharaInteractive.SetActive(false); 
        //slave
        SlaveAmountText.SetActive(false); 
        SlaveInteractive.SetActive(false); 
        //caravn
        CaravanText.SetActive(false); 
        CaravanInteractive.SetActive(false); 
                                                  //North

        WhiteSlaveText.SetActive(false); 
        WhiteSlaveInteractive.SetActive(false); 
        BlackSlaveText.SetActive(false); 
        BlackSlaveInteractive.SetActive(false); 
        WomenSlaveText.SetActive(false); 
        WomenSlaveInteractive.SetActive(false); 
        QuranText.SetActive(false); 
        QuranInteractive.SetActive(false); 
        MomText.SetActive(false); 
        MomInteractive.SetActive(false); 
        LeavingText.SetActive(false); 
        LeavingInteractive.SetActive(false); 
        DeadText.SetActive(false); 
        DeadInteractive.SetActive(false); 
        NonMuslimText.SetActive(false); 
        NonMuslimInteractive.SetActive(false); 
        //Other Scripts
        ActionButtons.SetActive(false); 
        FindObjectOfType<SaharaMoreInfo>().closemtext();
        SaharaMoreInfo.CurrentMTxt = "none";
    }

    void SudanBack(bool Cstate){
        MediterInteractive.SetActive(Cstate);
        KidnapInteractive.SetActive(Cstate);  
        GoldInteractive.SetActive(Cstate); 
        TradeInteractive.SetActive(Cstate); 
        Qs.SetActive(Cstate);
    }

    void SudanClicked(){
        MediterText.SetActive(false); 
        KidnapText.SetActive(false); 
        GoldText.SetActive(false);
        TradeText.SetActive(false); 
    }
    //talk

    public void TalkModel(){
    if(isTalking == true){
    switch(currentTxt)
        {
            case "PrayerTalk":   
            startTalking("Caravans held collective prayers at halting places, but it is not clear whether some of the male trade slaves were also invited to take part. Yet the fact is that some traders did try to ensure that both their male and female slaves, and especially the younger and more impressionable ones, were offered to final owners as instructed Muslims. This was especially the case with the more valuable slaves whose final price would be raised by their Islam, as also by their knowledge of Arabic.");
            isTalking = false;
            break;


            case "SlaveAmountTalk":
            startTalking("From a slow start under the stimulus of a growing, intercontinental Islamic demand in the late seventh century, the regular transit of slaves along all the Saharan roads may have risen to a peak of 5,000 slaves/year in the tenth century, falling off in response to more difficult marketing conditions over the next 200 years (particularly in northern Africa) and then recovering to reach its natural plateau of 5,000 slaves/year during the thirteenth, fourteenth and fifteenth centuries. While sudden increases in the size of the trade from one century to the next were unlikely, it is also doubtful that the system could really cope with as many as 20,000 slaves/year for many consecutive centuries during and after the late Middle Ages, as Raymond Mauny has suggested ");
            isTalking = false;
            break;

            case "SaharaTalk": 
            startTalking("Few places on earth are more desolate than the Sahara, the largest of the hot deserts. Taking on its present form some 4,000–5,000 years ago, it became a formidable obstacle to human contact. It separated ‘black’, inner Africa socially and culturally from its Mediterranean and Asian neighbours, while isolating the ‘white’ northern quarter to the north of the desert from the greater part of the continent to the south.");
            isTalking = false;
            break;


            case "CaravanTalk":
            startTalking("Caravans were slow and precarious: at an average of 2.5 mph they could not cover much more than 20 miles in an eight-hour daily journey, even under fair conditions. Each animal had to be loaded and unloaded at least once daily, and sometimes twice. Depending on travelling conditions and breed, a camel carried 120–150 kg but, because many journeys were long (up to two months between some main supply centres) about one-third of baggage animals in any caravan simply carried supplies for the journey. ");
            isTalking = false;
            break;

            case "WhiteSlavesTalk":
            startTalking("In Muslim North Africa, the military, labouring and domestic slaves (both black Africans imported across the Sahara and white Europeans from Mediterranean Christendom) made scant contribution to the economy. The Arab and wider Islamic Worlds needed slaves for sundry economic and social roles. There was some heavy male slave labour to be done; some regimes sometimes recruited black slave armies or corps of black slave guards; and some male slaves became the trusted agents of their masters. But both North Africa and the Middle East normally lacked the great agricultural estates, the latifundia of Roman type, or American-style planta- tions, worked only by slave-gangs.");
            isTalking = false;
            break;

            case "BlackSlaveTalk":
            startTalking("Slaves were kept because they were useful; they were sexually available; versatile; mobile; capable of supporting and sometimes reproducing themselves. They could make up for scarce human resources in a particular society, being given work or military duties free people could or would not do. Depending on age, sex, appearance and skills, they might be valuable, marketable investments and redeemable assets, perhaps to be given as tribute or presents, and often conferring prestige on their rich or otherwise important owners: ‘wealth in people was often thought more important than wealth in property’.");
            isTalking = false;
            break;

            case "SlaveGirlsTalk":
            startTalking("Thus ‘the female slaves formed a vital section of the working population, insofar as they provided domestic help, a type of work shunned by free women . . . the larger households could hardly do without [such] domestic help.’ Berber women slaves were valued for housework; black women were considered docile (‘born to slavery’), robust and excellent wet-nurses; Greeks could be trusted with precious things around the house. Such slaves and concubines, unlike the slave-gangs of the Americas, may have made domestic life easier and the choice of sexual partner more varied in the middle-class homes of North Africa and the Middle East, but they contributed little to the local economy or the processes of long-term capital accumulation.");
            isTalking = false;
            break;

            case "QuranTalk":
            startTalking("A few black, formerly pagan, slaves became pious Muslims, integrated well into Maghrebi or Levantine Islamic society, and occasionally rose to positions of authority, but most did none of these things. Under sharia law, new slaves could be recruited only by birth in slavery or by capture in war. Muslims could not enslave fellow-Muslims: a Muslim thus reduced to slavery suffered a grievous injustice, but a slave who became a Muslim remained a slave: all depended on the sequence of events. The status of a non-Muslim slave who converted was not altered by his Islam.  Nevertheless, even if slavery in the Islamic World was more a matter of religion than race, Muslim slave-traders in sub-Saharan Africa were sometimes unable to resist the temptation of enslaving free black Muslims merely because they were black. 	");
            isTalking = false;
            break;

            case "SingleMomTalk":
            startTalking("Slave communities in the Islamic World were constantly eroded by early deaths in alien climates and disease environments; by poor treatment and living conditions; by the freedom of children born of free fathers and slave women (for, in contrast to common American practice, no Muslim father could have a slave child); and by manumission (but in both Islam and Jewry the freed slave still often depended on the former master).");
            isTalking = false;
            break;

            case "SlaveLeaveTalk":
            startTalking("Moving slaves from their place of capture to final buyers was a long, hazardous and complex process. The several transitions from victim of war, raiding, kidnapping, punishment or sale deep in tropical Africa, to trade slave, and finally to domestic ornament in a Mediterranean Muslim house- hold were usually spread over many months. ");
            isTalking = false;
            break;

            case "DeadTalk":
            startTalking("Travellers were horrified by the casual inhumanity and prodigal indiffer- ence of slave-traders towards their charges. Even in death, they clearly considered their slaves as mere pagans, deserving neither respect nor burial: most dead slaves were simply left where they had fallen. This may have been understandable on difficult stretches of road, where no caravan-leader would risk all lives by halting for stragglers or to bury the dead. But it was harder to justify at wells and other resting places.");
            isTalking = false;
            break;

            case "NonMuslimTalk":
            startTalking("Nominal Muslim slaves continued openly to practice their animistic rituals and, while the authorities might tolerate such behaviour, slaves were as a result largely excluded from their adoptive societies. The persistence of such traditional beliefs and rituals seems partly to have been a defensive attitude of deracinated and economically and socially depressed communities trying to sustain memories of their origins and identity.");
            isTalking = false;
            break;

            case "MediterInteractiveTalk":
            startTalking("The few black slaves taken from time to time across the Sahara before the coming of the Arabs would no doubt have been seen on the far side of the Mediterranean more as exotic household ornaments than as necessary recruits to the existing and abundant pools of slave labour.");
            isTalking = false;
            break;

            case "KidnapInteractiveTalk":
            startTalking("In the first instance, not all slaves were made by outsiders. Some were enslaved by their own overlords; by kidnapping; as punishment for crime; individuals might be sold into slavery by their own families in times of distress; others were enslaved by aggressive and stronger neighbours during raids or longer warfare. Al-Yaqubi wrote in the ninth century how ‘the kings of Sudan will sell their people without any pretext of war’. As for kid- napping, the anonymous author of Hudud al-Alam reported that there were in the Sudan ‘people who steal children from each other to sell them to [foreign] merchants when they go there’.");
            isTalking = false;
            break;

            case "GoldInteractiveTalk":
            startTalking("In the western Sudan, first Ancient Ghana (ninth and tenth centuries) and then the Empires of Mali (fourteenth century) and Songhai (fifteenth–sixteenth centuries) became the sub-Saharan entrepots first of the gold trade and second of the slave trade along the western and west- central desert roads.");
            isTalking = false;
            break;

            case "TradeInteractiveTalk":
            startTalking("It may be argued that there was no regular trans-Saharan trade system before the rise of the camel-mounted Berber nomad in the first Christian centuries and perhaps not even until after the arrival of the first camel-riding Muslim Arabs in North Africa in the seventh century. Gold dust, animal skins, ivory, ingredients for perfume-making, black slaves – the attested staples of the medieval export trade of inner Africa – may have been carried across the desert from time to time in the classical era.");
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
    //close text
    public void CloseInetrativeModel(){
        closeAllText();
        ResetSize();
        SudanBack(true);
        SudanClicked();
        SaharaScaleANDRotate.Isenabled = false;
        closeN = false;
        closeS = false;
        NonInteractive.SetActive(true); 
        NonInteractiveNORTH.SetActive(true); 
        pane_buttonsGone.SetActive(true);
        ActionButtons.SetActive(false); 
        stopTalking();

        if(SubSaharan_Sudan.activeSelf){
           pane_buttonsGone.SetActive(false); 
        }
        
    }

    void ResetSize(){
        //scale
        //PrayerInteractive.transform.localScale = PrayerStartPos;
        SaharaInteractive.transform.localScale = SaharaStartPos;
        //SlaveInteractive.transform.localScale = SlaveStartPos;
        CaravanInteractive.transform.localScale = CaravanStartPos;
        MediterInteractive.transform.localScale = medi;
        KidnapInteractive.transform.localScale  = kidn;
        GoldInteractive.transform.localScale  = fold;
        TradeInteractive.transform.localScale  = trade;
        
    }
    
    //speech
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }

   public void DestroyAll(){
       Destroy(this.gameObject);
   }


}
