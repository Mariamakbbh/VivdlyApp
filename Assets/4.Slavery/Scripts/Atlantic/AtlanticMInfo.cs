using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtlanticMInfo : MonoBehaviour
{
    public GameObject AfricaNameMText, GoldCoastMText, JesusMText, MaskMText, TriangleMText, PortugeseMText, WithdrawalCostMText, BritishAbolishMText, WithdrawalCostWaitMText;
    //COMMON
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
            case "AfricaNameTalk":
            stopTalking();
            CurrentMTxt = "AfricaNameTalk";
            AfricaNameMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "GoldCoastTalk":
            stopTalking();
            CurrentMTxt = "GoldCoastTalk";
            GoldCoastMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "JesusTalk":
            stopTalking();
            CurrentMTxt = "JesusTalk";
            JesusMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "MasksTalk":
            stopTalking();
            CurrentMTxt = "MasksTalk";
            MaskMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "TriangleTalk":
            stopTalking();
            CurrentMTxt = "TriangleTalk";
            TriangleMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "PortugeseTalk":
            stopTalking();
            CurrentMTxt = "PortugeseTalk";
            PortugeseMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "WithdrawalCostTalk":
            stopTalking();
            CurrentMTxt = "WithdrawalCostTalk";
            WithdrawalCostMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "BritishAbolishTalk":
            stopTalking();
            CurrentMTxt = "BritishAbolishTalk";
            BritishAbolishMText.SetActive(true);
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

             case "WithdrawalCostWaitTalk":
            stopTalking();
            CurrentMTxt = "WithdrawalCostWaitTalk";
            WithdrawalCostWaitMText.SetActive(true);
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
   CurrentMTxt = "none";
   closemtext();
   stopTalking();
}

public void closemtext(){
    BackgroundTexts.SetActive(false);
    backblurr.SetActive(false);
    OnlineExplore.SetActive(false);
    isTalking = false;

    //all text 
    AfricaNameMText.SetActive(false);
    GoldCoastMText.SetActive(false);
    JesusMText.SetActive(false);
    MaskMText.SetActive(false);
    TriangleMText.SetActive(false);
    PortugeseMText.SetActive(false);
    WithdrawalCostMText.SetActive(false);
    BritishAbolishMText.SetActive(false);
    WithdrawalCostWaitMText.SetActive(false);
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
            case "AfricaNameTalk":
            startTalking("But it was only from the 15th century, when Portuguese mariners brought the outline of Africa into the purview of Europe, that the term was generally applied to the entire continent. In early pan-Africanist thought, Africa – or ‘Ethiopia’, as the continent continued sometimes to be called – was seen as the home of a distinctive people, the ‘Negro race’. It was only towards the end of the 19th century that these ideas began to develop within Africa itself, emerging first among the literate, English-speaking communities of the trading towns of coastal West Africa. By then, the continent stood on the cusp of European colonial conquest, a condition that would further consolidate for many what it meant to be African. North Africa has in turn presented a problem for those who have sought to define Africa and the ‘black race’. Europeans in the age of imperialism may have perceived the region as part of a decaying orient, as Said argues. But it was still seen to lie within the realm of history – in contrast with the timeless primitiveness of ‘tribal’ Africa to the south.");
            isTalking = false;
            break;
            
            case "GoldCoastTalk":
            startTalking("The external trade during this period of time therefore did not contribute to any further monetization of this part of the African coast. With the arrival of the Europeans, gold was rather exported from the coast, in exchange for a variety of European goods. During the early period of contact with the Europeans, there were therefore virtually no exports of slaves from the Gold Coast. On the contrary, slaves were probably imported into the region, for example to work in the gold mines. This would however change in the late 17th century, when rising prices for slaves led to a demand for slaves from this region as well. In the 1660s, exports of slaves began from the Gold Coast, increasing drastically from the 1690s. In the 1730s, the slave trade reached a first peak.");
            isTalking = false;
            break;

            case "JesusTalk":
            startTalking("In West Africa, on the other hand, Christianity was for a long time largely confined to coastal communities, where Europeans needed intermediaries, or where they sometimes settled and “went native,” producing interracial, intercultural families. Attempts to convert the indigenous tended to be limited to non-Muslim populations, with very little effort devoted to converting Muslims, seen as a waste of time. Campaigns to convert large numbers of Africans became much more organized with the official onset of colonialism late in the nineteenth century, though the Dutch, Germans, and English had been steadily encroaching upon African lands in southern Africa since the late sixteenth century, while the French had been operating in Senegal since the nineteenth. The French were less zealous about promoting Catholicism, while British missionaries were far more active, establishing schools and churches through which many African elites were subsequently produced.");
            isTalking = false;
            break;

            case "MasksTalk":
            startTalking("It would appear, then, that at least in the case of West Africa and arguably West Central Africa, the introduction of both Islam and Christianity was neither planned nor coordinated by external powers and followed the logics of commercial enterprise. A sizable number of Africans embraced these religions, joining elite formations here and there, but the majority of Africans were slow to respond to either religion and did so only when faced with the exigencies of war, conquest, and subsequent rule. Throughout the four-hundred-year history of the transatlantic slave trade, there is very little evidence that enslavers were very preoccupied with converting Africans. Though the Portuguese often baptized captives prior to leaving West Central African ports, often branding them a cross to boot, there was very little in the way of formal catechism on either side of the Atlantic.");
            isTalking = false;
            break;

            case "TriangleTalk":
            startTalking("For more than 2,000 years people in many different parts of the world have forced their fellow humans into slavery. Between about 1500 and 1900, Europeans forcibly uprooted millions of people from throughout West Africa and West Central Africa and shipped them across the Atlantic in conditions of great cruelty. To refer to the Africans who were enslaved only as 'slaves' strips them of their identity. They were, for instance, farmers, merchants, priests, soldiers, goldsmiths and musicians. They were husbands and wives, fathers and mothers, sons and daughters. They could be Yoruba, Igbo, Akan or Kongolese. The triangle, involving three continents, was complete. European capital, African labour and American land and resources combined to supply a European market. The colonists in the Americas also made direct slaving voyages to Africa, which did not follow the triangular route. This trade increased after 1800, particularly from Brazil. The story of the transatlantic slave trade is the story of people on all three continents, as well as the dreaded 'Middle Passage' voyage.");
            isTalking = false;
            break;

            case "PortugeseTalk":
            startTalking("Between the 1440s, when Portuguese mariners first began to kidnap and to purchase Africans, and 1867, the year of the last recorded slaving voyage to the Americas, some 12 million men, women, and children were turned into commodities and exported from the continent. This bare statistic only goes so far in capturing the violence, the devastation, and the degradation initiated by what anti-slave trade campaigners called this ‘odious commerce’. It does not include the countless lives lost through slave raiding, warfare, and social breakdown within Africa, nor those captives who succumbed to disease or maltreatment before embarkation. Neither does it include those enslaved but not exported, as Atlantic commerce acted as a catalyst for the expansion and intensification of slavery in African societies. And it does not include those Africans who were born and then died in the cauldron of the American slave system. Joseph Miller captures in one phrase this history of systemized suffering: the slave trade in Angola, he writes, became a ‘way of death’.");
            isTalking = false;
            break;

            case "WithdrawalCostTalk":
            startTalking("The Windward Coast supplied approximately 89,000 slaves to the Dutch in this period, which means 11,000 more slaves than the Transatlantic Slave Trade Database suggests. The Transatlantic Slave Trade Database consequently underrates the size of the slave trade from Cape Lahou, for which it suggests an estimated total of nearly 15,000 slaves embarked by all national carriers between 1709 and 1820. Throughout the history of the Atlantic slave trade, no region in Africa supplied fewer slaves to the Americas than the Windward Coast. According to the TSTD2, an estimated total of 337,000 slaves were carried from the Windward Coast, of which 290,000 embarked in the eighteenth century alone. This study is based on a database of 72 slaving voyages undertaken by the MCC between 1740 and 1802. The MCC organized a total of 114 slaving voyages between 1732 and 1802, all but two of which were carried out between 1740 and 1794.27 Eighty voyages were destined to the Guinea Coast, three to Gabon, and thirty-one to the Loango Coast. The share of males among the slaves purchased on the coast west of Lahou was a mere 52 percent; meanwhile children formed an extraordinarily large fraction of the slaves taken from the Kru coast (42 percent). Cape Lahou exported relatively few children, but the female share was still exceptionally high (45 percent). East of Lahou, slave purchases focused increasingly on males and included very few children. Compared to the Atlantic slave trade in general, females were overrepresented in the Guinea trade and children underrepresented, despite the large numerical presence of the latter among the slaves carried from the coast west of Lahou.");
            isTalking = false;
            break;

            case "BritishAbolishTalk":
            startTalking("Over subsequent decades, Britain cajoled other slave-trading nations to follow suit, imposing a naval blockade of the West African coast and threatening to do the same to Brazil. By the 1850s, the illegal trade was reduced to a trickle. British motives were shaped by a mixture of economic self-interest and high-minded humanitarianism. For the rulers of the coastal middlemen states, however, what the campaign amounted to was a unilateral embargo on their most important export commodity: people. The subsequent encouragement of non-slave exports (so-called legitimate commerce) also carried the tone of a moral crusade. By the high Victorian period, a combination of ‘Christianity, civilization, and commerce’ was seen to be the key to the redemption of a benighted continent. Yet slavery within Africa, far from ‘withering away’ with the end of the Atlantic trade as abolitionists had hoped, expanded. Slave labour once exported to the Americas was now exploited more intensively in Africa – ironically, often as a result of the demand for new commodities. ");
            isTalking = false;
            break;

            case "WithdrawalCostWaitTalk":
            startTalking("Indeed, 22 percent of the slaves were bought in the last of the seven or eight months spent on the African coast, and 15 percent during the final week. Mortality normally increased for all slaves throughout the loading phase, as well the Middle Passage, but death rates of children and women usually remained lower than those of men. It seems that Africans sold into the Atlantic slave trade from the coast west of Lahou were mostly victims of such local or internal means of enslavemnet. Second, more adult women than men were sold into the Atlantic slave trade, while children formed an exceptionally high portion of the exported slaves (among the children boys predominated). In 1807 the British Parliament passed a bill prohibiting the slave trade. In January the  following year the United States followed suit by outlawing the importation of slaves. The acts did nothing to curtail the trade of slaves within the nation's borders, but did end the overseas commerce in slaves. Brazil outlawed the slave trade in 1850, but the smuggling of new slaves into Brazil did not end entirely until the country finally enacted emancipation in 1888. Stopping suspected slave traders and confiscating the ship when slaves were found. The human cargo was then transported back to Africa.");
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
    Application.OpenURL("https://www.youtube.com/watch?v=3NXC4Q_4JVg");
}


    //additional resources BOOK 
public void ExternalBookMoreText(){

        Application.OpenURL("https://ebookcentral.proquest.com/lib/brunelu/detail.action?docID=415063");
}

}

