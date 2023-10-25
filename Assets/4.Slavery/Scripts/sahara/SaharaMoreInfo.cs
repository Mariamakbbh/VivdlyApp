using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaharaMoreInfo : MonoBehaviour
{
    public GameObject BackgroundTexts, backblurr, OnlineExplore, PrayerMText, SaharaMText, SlaveAmountMText, CaravanMText;
    public GameObject WhiteSlaveMText, BlackSlaveMText, WomenSlaveMText, QuranMText, LeavingMText, DeadMText;
    public GameObject MediterMText, KidnapMText, GoldMText, TradeMText, book;
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
            case "PrayerTalk": 
            stopTalking();
            PrayerMText.SetActive(true);
            CurrentMTxt = "PrayerTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;


            case "SlaveAmountTalk":
            stopTalking();
            SlaveAmountMText.SetActive(true);
            CurrentMTxt = "SlaveAmountTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "SaharaTalk": 
            stopTalking();
            SaharaMText.SetActive(true);
            CurrentMTxt = "SaharaTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;


            case "CaravanTalk":
            stopTalking();
            CaravanMText.SetActive(true);
            CurrentMTxt = "CaravanTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

                                                   //North Africa
            case "WhiteSlavesTalk":
            stopTalking();
            WhiteSlaveMText.SetActive(true);
            CurrentMTxt = "WhiteSlavesTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "BlackSlaveTalk":
            stopTalking();
            BlackSlaveMText.SetActive(true);
            CurrentMTxt = "BlackSlaveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "SlaveGirlsTalk":
            stopTalking();
            WomenSlaveMText.SetActive(true);
            CurrentMTxt = "SlaveGirlsTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "QuranTalk":
            stopTalking();
            QuranMText.SetActive(true);
            CurrentMTxt = "QuranTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "SlaveLeaveTalk":
            stopTalking();
            LeavingMText.SetActive(true);
            CurrentMTxt = "SlaveLeaveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "DeadTalk":
            stopTalking();
            DeadMText.SetActive(true);
            CurrentMTxt = "DeadTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

                                                   //SUDAN 
            case "MediterInteractiveTalk":
            stopTalking();
            MediterMText.SetActive(true);
            CurrentMTxt = "MediterInteractiveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "KidnapInteractiveTalk":
            stopTalking();
            KidnapMText.SetActive(true);
            CurrentMTxt = "KidnapInteractiveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "GoldInteractiveTalk":
            stopTalking();
            GoldMText.SetActive(true);
            CurrentMTxt = "GoldInteractiveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            case "TradeInteractiveTalk":
            stopTalking();
            TradeMText.SetActive(true);
            CurrentMTxt = "TradeInteractiveTalk";
            Invoke("OpenTalk",1);
            isTalking = true;
            break;

            default:
            break;
        }
    }
}


//close all
public void CloseMoreText(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    PrayerMText.SetActive(false);
    SlaveAmountMText.SetActive(false);
    SaharaMText.SetActive(false);
    CaravanMText.SetActive(false);
    //NOAF
    WhiteSlaveMText.SetActive(false);
    BlackSlaveMText.SetActive(false);
    WomenSlaveMText.SetActive(false);
    QuranMText.SetActive(false);
    LeavingMText.SetActive(false);
    DeadMText.SetActive(false);
    //SUDAN
    MediterMText.SetActive(false);
    KidnapMText.SetActive(false);
    GoldMText.SetActive(false);
    TradeMText.SetActive(false);
    stopTalking();
    isTalking = false;
}

public void closemtext(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    PrayerMText.SetActive(false);
    SlaveAmountMText.SetActive(false);
    SaharaMText.SetActive(false);
    CaravanMText.SetActive(false);
    //NOAF
    WhiteSlaveMText.SetActive(false);
    BlackSlaveMText.SetActive(false);
    WomenSlaveMText.SetActive(false);
    QuranMText.SetActive(false);
    LeavingMText.SetActive(false);
    DeadMText.SetActive(false);
    isTalking = false;
    //SUDAN
    MediterMText.SetActive(false);
    KidnapMText.SetActive(false);
    GoldMText.SetActive(false);
    TradeMText.SetActive(false);
}


//spoke
public void startTalking(string message){
    FindObjectOfType<VoiceController>().startSpeacking(message);
  }

public void stopTalking(){
    FindObjectOfType<VoiceController>().StopSpeacking();
    FindObjectOfType<VoiceController>().stopAnim();
  }



//talking

public void OpenTalk(){
    if(isTalking == true){
    switch(CurrentMTxt)
        {
            case "PrayerTalk":   
            startTalking("Some nineteenthth-century European sources suggest that few attempts to instruct slaves in Islam or the Arabic language were made until the very end of their trans-Saharan journeys. At resting places outside such important outlets as Benghazi, Tripoli and Marrakesh, some belated attention might be given to slaves’ spiritual and linguistic education. This was while they were prepared for market by being decently clothed, coifed, oiled (to give their skins a sleek, ‘healthy’ sheen) and encouraged to put on some weight. Caravans held collective prayers at halting places, but it is not clear whether some of the male trade slaves were also invited to take part. Yet the fact is that some traders did try to ensure that both their male and female slaves, and especially the younger and more impressionable ones, were offered to final owners as instructed Muslims. This was especially the case with the more valuable slaves whose final price would be raised by their Islam, as also by their knowledge of Arabic.");
            isTalking = false;
            break;


            case "SlaveAmountTalk":
            startTalking("From a slow start under the stimulus of a growing, intercontinental Islamic demand in the late seventh century, the regular transit of slaves along all the Saharan roads may have risen to a peak of 5,000 slaves/year in the tenth century, falling off in response to more difficult marketing conditions over the next 200 years (particularly in northern Africa) and then recovering to reach its natural plateau of 5,000 slaves/year during the thirteenth, fourteenth and fifteenth centuries. While sudden increases in the size of the trade from one century to the next were unlikely, it is also doubtful that the system could really cope with as many as 20,000 slaves/year for many consecutive centuries during and after the late Middle Ages, as Raymond Mauny has suggested.This, then, was a particular business system that came into being as a fixed, annual enterprise in response to specific conditions, stimuli and demands in the early Islamic era. So it continued to work and prosper in much the same unhurried and unchanging ways for well over a thousand years. Yet it managed to take some early advantage from the first big challenge to its well-guarded monopolies. That challenge came in the fifteenth century from pioneering Portuguese navigators in West Africa, and their first landfalls in search of slaves on the long, desolate Atlantic coasts of the Western (ex- Spanish) Sahara.");
            isTalking = false;
            break;

            case "SaharaTalk": 
            startTalking("The Sahara lies between three main poles of human attraction: the Sudanic lands to the south; the Mediterranean world to the north; and Egypt and the Levant to the east. The Saharan environment is difficult because it is both very hot yet at times cold enough for frost; it has low precipitation and high evaporation; it lacks water and vegetation; it has many harsh and hostile landscapes and inhabitants; but above all because it is so vast. Few places on earth are more desolate than the Sahara, the largest of the hot deserts. Taking on its present form some 4,000–5,000 years ago, it became a formidable obstacle to human contact. It separated ‘black’, inner Africa socially and culturally from its Mediterranean and Asian neighbours, while isolating the ‘white’ northern quarter to the north of the desert from the greater part of the continent to the south.");
            isTalking = false;
            break;


            case "CaravanTalk":
            startTalking("Clearly, the medieval Sahara was anything but an impassable barrier between North and Sudanic Africa. Because of the length, difficulties and dangers of Saharan travel, and the limited load capacity of even the largest caravan (not least because it was normal practice for every third camel to carry food and water for the journey), only the most profitable trade-goods could bear the high costs of the desert crossing. All merchandise had to have a high value in relation to weight, and if freight charges added between 100 and 150 per cent to the price of most items, charges were lower for goods with higher value:weight ratios.93 This, then, was essentially a trade in luxuries. As one such luxury, most slaves, including even the little children, provided their own transport because they trekked across the desert, sometimes carrying loads of up to 15 kg on their heads to save camel transport: ten loaded slaves might carry as much as one loaded camel. But slaves also had to be guarded and fed, taxes paid on them, and allowance made for deaths from many different causes on the road. Caravans were slow and precarious: at an average of 2.5 mph they could not cover much more than 20 miles in an eight-hour daily journey, even under fair conditions. Each animal had to be loaded and unloaded at least once daily, and sometimes twice. Depending on travelling conditions and breed, a camel carried 120–150 kg but, because many journeys were long (up to two months between some main supply centres) about one-third of baggage animals in any caravan simply carried supplies for the journey. ");
            isTalking = false;
            break;

            case "WhiteSlavesTalk":
            startTalking("Figures from around 1850 suggest that gross profits of around 200 per cent could be made on the trade in young slave boys and girls between the Hausa States (northern Nigeria) and the mid-Saharan slave market at Murzuk, with further profits on sales at yet more distant markets. In all these places, prices for slaves varied widely according to age, sex, skills, origins (to some extent) and the laws of supply and demand. In the tenth century, Al-Istakhri reported that ‘an unskilled slave girl or man will fetch, according to his or her appearance, 1,000 dinars or more’.  From his context, it is unclear whether this was the price of ‘black slaves from the land of Sudan’ or ‘white slaves from Al-Andalus’ (Spain).");
            isTalking = false;
            break;

            case "BlackSlaveTalk":
            startTalking("The first ‘modern’ people to create this constant demand for large numbers of foreign slaves were the Arabs ‘and their light-skinned converts to Islam from Morocco to Iran’. This demand lasted from the seventh century until, in some places, well into the twentieth. Once established, the Islamic Caliphal empire, dominating trade and communications between the three Old World continents, drew on slaves from beyond the frontiers of Islam, where jihad (holy war) was legitimately waged against heathens rather than Christian or Jewish infidels.  For many centuries the peoples of inner Asia and Europe (especially the pagan Slavs from whom the very word slave derives) were main sources of captives. But for the Islamic World the most lasting and seemingly limitless slave reservoir was sub-Saharan Africa, where slavery was endemic and where surplus slaves were readily available for export by the Red Sea, down the Nile Valley, or across the Sahara.");
            isTalking = false;
            break;

            case "SlaveGirlsTalk":
            startTalking("Thus the main demand for slaves in the Islamic World was for women and girls as household servants, entertainers and/or as concubines. ‘The most common and enduring purpose for acquiring slaves in the Arab World was to exploit them for sexual purposes.’ This seems reasonable when it is accepted (and the slave trade returns of nineteenth-century British consular officials in North Africa and the Sahara confirm) that about two-thirds of slaves taken across the desert were women and girls, either to be sold singly, or to be presented in a group to the appropriate authority as tribute, a tax settlement or a gift. Conversely, physical and moral defects in slaves could lower their value or, if undeclared, result in their return to the seller within three days of purchase. Such defects included epilepsy, leprosy, flat feet, insomnia, anorexia, dissolute habits, and a tendency to alcoholism or absconding. One difference was that the Islamic societies served by the Saharan trade demanded twice as many servile women as men, almost the reverse of the Atlantic ratio, and once slaves had crossed the Sahara, most were better treated than those on the American plantations. ");
            isTalking = false;
            break;

            case "QuranTalk":
            startTalking("By the time slaves reached their final point of sale in North Africa or the Levant, they were already nominal Muslims with at least some Arabic, for there were no buyers for a ‘pagan’ slave with no known speech. The slave- dealers had ensured that the male slaves were circumcised as necessary and that all slaves had been given Arabic names. ‘These names were often peculiar to slaves and tended to have meanings which were redolent of happiness, good fortune and favour from God.’ Such, at least, seems to have been the practice in modern times; but in the High Middle Ages (tenth– thirteenth centuries) there was apparently less concern for slaves’ religion. In Islam, slaves may have been ‘a mere commodity generally ranking with the domestic animals’, or in Moroccan society could be ‘perceived as beasts with the faculty of communicating and being believers’.  Thus some of those kept at the great religious centre at Smara in the western Sahara in the late nineteenth century lived in open pens with the goats and camels. But slavery in the Islamic World was usually very different from the harsh mine or plantation slavery of the Americas, and a strong case has always been made for its benign face. The slave in Islam had the same spiritual value and eternal expectations as the free man, although, unless emancipated, he had simply to resign himself to a lifetime’s inferior status. While Islamic law and practice made no provision for the abolition of slavery or the slave trade, Islam did try ‘to moderate the institution and mitigate its legal and moral aspects’, even if there were often gulfs between doctrine and practice.  The Koran accepts the existence of the institution of slavery but refers only rarely to it, mostly stressing the merits of manumission.  Koranic references urging real kindness towards slaves, and the virtues of manumission attributed to the Prophet and his companions in the hadith – ‘do not forget that they are your brothers’ – effectively applied to Muslim slaves only.  ");
            isTalking = false;
            break;

            case "SlaveLeaveTalk":
            startTalking("Even after being force-marched out of the Sudan and crossing the Sahara to the Maghreb, some slaves were moved still further on, perhaps across the Western Desert to Egypt, or shipped across the Mediterranean to other parts of the Arab World or, from the sixteenth century, to provinces of the Ottoman Empire in the Balkans, the Aegean or Anatolia. Their survival of this coerced and mostly brutal migration, and the often deadly conditions of the slave-marshalling centres and markets,104 was a matter of gender, youth, sound mind and constitution, and good fortune.");
            isTalking = false;
            break;

            case "DeadTalk":
            startTalking("Black slaves were known to be prone to the recurrent outbreaks of plague in the Middle East and North Africa. Slaves were usually imported when they were young, most had no immunity to plague ‘and were consequently susceptible to the disease environment of their new surroundings’.  The cold, damp North African and Levantine winter also killed off people raised in the tropics. Over half the recorded slave deaths in Tripoli in the 1840s were due to winter ‘pulmonary affections’, the average age at death being only. According to another contemporary statistic, three-quarters of the black slaves shipped from North Africa to the Levant eventually died there of consumption.");
            isTalking = false;
            break;

            case "MediterInteractiveTalk":
            startTalking("Before the first Arab invasion of North Africa in the seventh century, the Sahara was a passage only for infrequent trade on a continental, if not an intercontinental scale. The volume of trade was small, and probably made little economic impact on either side of the desert. Apart from gold, inner Africa produced little that was wanted in the Mediterranean world, or was worth carrying there. Trade is likely to have developed through contacts made during nomads’ seasonal migrations and predatory visits to oases and desert fringe com- munities. Regular markets and yearly fairs grew up where different peoples came together. Trading middlemen started by supplying goods and, with their nomadic associates, ancillary services to transhumant tribespeople, oasis-dwellers and settled communities within or on either sides of the desert.");
            isTalking = false;
            break;

            case "KidnapInteractiveTalk":
            startTalking("As many medieval Arab sources confirm, slave raids were also made during the course of wars, many of them in effect longer-distance and larger raids into the lands of weaker and more vulnerable peoples. Thus the twelfth- century geographer Al-Zuhri tells how Muslims of Ancient Ghana mounted annual, but not always successful, raids into the lands of the pagans whose ebony-wood clubs were no match for the iron weapons of the Ghanaians.");
            isTalking = false;
            break;

            case "GoldInteractiveTalk":
            startTalking("The many medieval Arab accounts of the trans-Saharan gold traffic thus concentrate on the western roads to Morocco and the central Maghreb, and they lay great stress on the golden wealth of Ancient Ghana. According to the early tenth-century geographer Ibn al-Faqih, gold grew there ‘in the sand, as carrots do, and is picked at sunrise’. The gift of the West African– Saharan gold trade to the economic wellbeing of the western Maghreb and southern Europe was to catch the imaginations of the great portolan chart- makers of the fourteenth and fifteenth centuries, with their remarkable grasp of inner African economic and political geography.");
            isTalking = false;
            break;

            case "TradeInteractiveTalk":
            startTalking("By the time Islam came to North Africa, the locals had already lost some of their old fear of the Sahara. To the camel-mounted Berber nomad, warrior or trader, it no longer loomed as the formidable natural barrier it had once seemed. By exploiting the unique advantages of the Asiatic camel, North Africans had by the early Middle Ages mastered long-range desert travel. Within a century of the first Arab incursions, Berber merchants were bringing a fairly regular supply of black slaves across the central desert to the new Islamic Caliphal empire. These captives came from the largest and seemingly limitless reservoirs of enslavable peoples in sub-Saharan Africa. For the medieval Islamic World, inner Africa became almost synonymous with, and a legitimate source of slaves.");
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
    
 
    Application.OpenURL("https://www.youtube.com/watch?v=5OdIqeWkhHU");
           
    }


    //additional resources BOOK 
public void ExternalBookMoreText(){
    Application.OpenURL("https://ebookcentral.proquest.com/lib/brunelu/detail.action?docID=415063");   
    
     }
}
