using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernMTxt : MonoBehaviour
{
    public GameObject ConflictMTxt, peopleMTxt, landMTxt, trustMTxt; 
    public GameObject CanadaMTxt, MigrationMTxt, ColourismMTxt, BloodPressureMTxt; 
    public GameObject MalcomeXMTxt, MLKMTxt, GeorgeFMTxt, MandelaMTxt;
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
//MODERN
            case "ConflictTalk":
            stopTalking();
            ConflictMTxt.SetActive(true);
            CurrentMTxt = "ConflictTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "peopleTalk":
            stopTalking();
            peopleMTxt.SetActive(true);
            CurrentMTxt = "peopleTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "TrustTalk":
            stopTalking();
            trustMTxt.SetActive(true);
            CurrentMTxt = "TrustTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "LandTalk":
            stopTalking();
            landMTxt.SetActive(true);
            CurrentMTxt = "LandTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;
//DIASPORA   
            case "CanadaTalk":
            stopTalking();
            CanadaMTxt.SetActive(true);
            CurrentMTxt = "CanadaTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "MigrationTalk":
            stopTalking();
            MigrationMTxt.SetActive(true);
            CurrentMTxt = "MigrationTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "ColourismTalk":
            stopTalking();
            ColourismMTxt.SetActive(true);
            CurrentMTxt = "ColourismTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "BloodPressureTalk":
            stopTalking();
            BloodPressureMTxt.SetActive(true);
            CurrentMTxt = "BloodPressureTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "MalcomeXTalk":
            stopTalking();
            MalcomeXMTxt.SetActive(true);
            CurrentMTxt = "MalcomeXTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "MLKTalk":
            stopTalking();
            MLKMTxt.SetActive(true);
            CurrentMTxt = "MLKTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "GeorgeFTalk":
            stopTalking();
            GeorgeFMTxt.SetActive(true);
            CurrentMTxt = "GeorgeFTalk";
            isTalking = true;
            Invoke("OpenTalk",1);
            break;

            case "MandelaTalk":
            stopTalking();
            MandelaMTxt.SetActive(true);
            CurrentMTxt = "MandelaTalk";
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
    ConflictMTxt.SetActive(false);
    peopleMTxt.SetActive(false);
    landMTxt.SetActive(false);
    trustMTxt.SetActive(false);
    //DIASPORA
    CanadaMTxt.SetActive(false); 
    MigrationMTxt.SetActive(false);
    ColourismMTxt.SetActive(false);
    BloodPressureMTxt.SetActive(false);
    //HEROS
    MalcomeXMTxt.SetActive(false);
    MLKMTxt.SetActive(false);
    GeorgeFMTxt.SetActive(false);
    MandelaMTxt.SetActive(false);
}

//talking

public void OpenTalk(){
    if(isTalking == true){
    switch(CurrentMTxt)
        {
            case "ConflictTalk":
            startTalking("Most scholars today seem to agree that there was a close relationship between the external slave trade and local wars in Africa. What remains controversial is the direction of causality: were the wars fought in order to acquire slaves, or were slaves a by-product of wars fought for other reasons. During the late 17th and early 18th centuries, when the slave trade grew rapidly, the Gold Coast was ravaged by numerous conflicts and internal instability, perhaps most importantly between the Fante and the expanding Asante empire. In a recent study, Nunn (2008) examines the long-term impacts of Africa's slave trade. He finds that the slave trade, which occurred over a period of more than 400 years, had a significant negative effect on long-term economic development. ");
            isTalking = false;
            break;

            case "peopleTalk":
            startTalking("Africans built societies and political structures of staggering diversity and complexity across the continent. Europeans tended to categorize African political units as “tribes,” a profoundly problematic term; sufﬁce to say here that it only has validity or utility in particular contexts, and is largely a twentieth-century construct. In reality, African societies ranged from the nomadic to the centralized and territorial, from the transhumant pastoralist to the sedentary agricultural.");
            isTalking = false;
            break;

            case "TrustTalk":
            startTalking("Combining contemporary individual-level survey data with historical data on slave shipments by ethnic group, we ask whether the slave trade caused a culture of mistrust to develop within Africa. Initially, slaves were captured primarily through state organized raids and warfare, but as the trade progressed, the environment of ubiquitous insecurity caused individuals to turn on others - including friends and family members - and to kidnap, trick, and sell each other into slavery. Places farther from the coast had fewer slaves taken, and therefore exhibit higher levels of trust today. If distance from the coast affects trust only through the slave trade (i.e., if our exclusion restriction is satisfied), then there should be no relationship between distance from the coast and trust outside of Africa, where there was no slave trade. More slaves were supplied by ethnic groups that initially were less trusting, and that these lower levels of trust continue to persist today. Alternatively, there may be other historical events, such as formal colonial rule, that are correlated with the severity of the slave trade and subsequent levels of trust. They find a robust negative link between slave trades and trust, i.e., individuals whose ancestors were more exposed to the slave trade are today less trusting. The negative shock lasted well over 400 years, and we are examining its effects just over 100 years later. Therefore, it is possible that the effects of the shock on mistrust are still being felt today, even if they are actually temporary and ultimately will die out in the long run.");
            isTalking = false;
            break;

            case "LandTalk":
            startTalking("Physically, Africa has a strikingly regular coastline, with relatively few natural harbours in the form of deep bays and peninsulas; along other stretches of coast, maritime activity is inhibited by sand-bars. This has meant that Africans have not had the same opportunity as Europeans and Asians for maritime travel or exploration; with the exception of the coastal Mediterranean peoples, Africans have had frequent and intense contact with other continents only in comparatively recent times. This is not to suggest, again, that African society did not absorb external inﬂuences when these presented themselves, but rather that until the eighteenth and nineteenth centuries, African development was relatively self-contained; combined with difﬁcult terrain and a low level of transport technology, this meant that African civilization was in some important respects essentially insular in development and outlook.");
            isTalking = false;
            break;

            case "CanadaTalk":
            startTalking("Canada has also become an increasingly attractive destination for African immigrants. Africa's immigrant population in Canada increased from 101,700 in 1981 to 114,400 in 1986, and 166,200 in 1991, that is, at an annual rate of 6.3 percent. As a percentage of the total immigrant popu- lation, the African share rose from 2.6 percent in 1981 to 3.8 percent in 1991, while the share of the immigrant population in the total population remained steady at 16.1 percent both in 1981 and 19");
            isTalking = false;
            break;

            case "MigrationTalk":
            startTalking("Most enslaved Africans were brought to European colonies in Latin America, while 3–5% were brought to the United States of America (USA). These enslaved Africans and their descendants in the USA represent the group “African Americans”. As with other diasporan populations and indeed most of the world populations, African Americans have multiple ancestries with lineages from Africa, Europe, Asia, and Native America among others. Hence, the term “African American” is not a genetically homogeneous entity as reflected in the fact that self-identified African Americans include individuals ranging from almost no African ancestry to almost no European ancestry. The magnitude of the migration flows from Africa to the United States appears to be positively correlated, as Bernard Logan has argued, to population size, economic system and conditions, language policy, the development of higher education, and the colonial legacy, so that the largest numbers of African migrants have tended to come from countries with 'a large population; a pro-western, capitalist outlook; speakers of English, rather than any other European language; unstable economic conditions; a long history of well-established higher education; and a colonial legacy that had not been too culturally dominant'.  The African migrants in the United States are well-educated: in fact they enjoy the highest levels of education of any group in the United States, foreign-born or native-born. According to the US 2000 Census, among the African-born residents, 49.3 percent had a bachelor's degree or higher as compared with 25.6 percent for the native-born population and 25.8 percent for the foreign-born population as a whole. The irony of people from the least educated continent in the world having the highest levels of education in the world.");
            isTalking = false;
            break;

            case "ColourismTalk":
            startTalking("Despite society’s attitudes towards those considered as Black, white slave owners had unconsented sexual relations with African women. As chronicled by Russell, Wilson, and Hall, “[r]ape was a fact of life on the plantations. At any time and in any place, female slaves were subject to the drunken or abusive sexual advances of a master…. Few Black women reached the age of sixteen without having been molested by a white male”. This perverted sexual behaviour created generations of descendants who possessed light brown complexions. Referred to as Mulattos, these half African and half European individuals had the “privileges” of working as house servants instead of the typical field labour of their darker skin counterparts. Many had the opportunity to attain education and access to personal and material possessions. Typically, mixed-race slaves were also bought and sold at higher prices, signifying that light skin was a valuable commodity and thereby more desirable. “According to Frazier, mulattoes were conscious of the distinctions between themselves and darker slaves and believed that their white blood did indeed make them superior … the negative stereotypes associated with ‘blackness’ and the value placed on ‘lightness’ of skin by whites became widely accepted by the slaves”. Female slaves with light skin, in particular, were considered to be “gentler, kinder more [attractive], smarter and more delicate”. Although the institution of slavery was brought to an end, the colour caste remained in place as it became internalized within both the African-American and white population. Lighter skinned African Americans worked in a higher socioeconomic division than did those with darker skin. Persons with light skin held better jobs and many times were able to access those jobs in part by claiming to be white. In fact, some African Americans were so light they were able to successfully “pass” or “escape from their ‘proper’ inferior position” unknowingly to the white population at the time. Black woman categorized as dark-skinned confronts the unfortunate circumstance of associating herself with what is immoral, forbidden, and hated. ");
            isTalking = false;
            break;

            case "BloodPressureTalk":
            startTalking("Perceived racism typically refers to African Americans’ subjective experiences of White racism against African Americans. Although racism, such as institutional discrimination, can affect health in many forms, perceived racism focuses more on the ways in which experiences of racism are viewed as a social stressor by African Americans. Perceptions of racial discrimination are a particularly salient social stressor for African Americans, and therefore perceived racism may play an important role in the cardiovascular health of African Americans. Individuals reporting higher perceived frequencies of exposure to racism in academic settings had higher DBP. Perceived racism in public settings and reported frequency of racist statements were not associated with daytime or nighttime DBP. These findings provide evidence that perceived racism can be related to BP levels outside the laboratory, suggesting that experiences with racial discrimination may serve as an environmental stressor resulting in increased BP.");
            isTalking = false;
            break;

            case "MalcomeXTalk":
            startTalking("The Black Power movement represents a largely unchronicled epic in American history. Black Power fundamentally altered struggles for racial justice through an uncompromising quest for social, political, and cultural transformation. The movement's sheer breadth during the late 1960s and early 1970s encompassed virtually every facet of African American political life in the United States and beyond.2 Black college students protested for curricular changes that culminated in the development of black studies programs and departments at universities around the nation. African American politicians tapped into the groundswell of racial solidarity to help build urban political machines that elected black mayors in cities such as Detroit, Atlanta, Newark, and Gary, Indiana, and led to the formation of the Congressional Black Caucus.3 Black women utilized the militancy of the movement's urgent rhetoric to articulate a bold feminist vision (one that was often critical of Black Power's misogyny) and to assert their rights to expansive social services, especially in relation to bread-and-butter issues such as housing, education, and welfare.");
            isTalking = false;
            break;

            case "MLKTalk":
            startTalking("Until the Civil Rights Movement, whiteness was a legal category as well. Whiteness was not only assumed as the standard for valuing bodies. The standard was implemented by the law and through displays of force, which made racism easily recognizable. The Civil Rights Movement transformed whiteness from a legal category into a social norm. This diminished the raw brutality that characterized the previous era's incarnation of racism. It also made whiteness more inclusive. It did not, however, erase whiteness from the American landscape, where it persists as a fundamental feature of American life. Such an understanding of power and violence makes it difficult to discern racism in the post-Civil Rights era, in which the overt forms of racial discrimination that were common during the eras of slavery and Jim Crow have declined.");
            isTalking = false;
            break;

            case "GeorgeFTalk":
            startTalking("Since the Civil Rights era, some blacks, Latinos, Asians, and Native Americans have been able to enjoy benefits previously reserved for whites—for example, economic wealth, public office, and access to higher education. Nonetheless, whiteness has remained a meaningful category in American life. As Hurricane Katrina revealed, the American underclass remains disproportionately non-white. A disproportionate number of blacks, Latinos, and Native Americans are poor and unemployed. Rather than waging war on non-whites, post-Civil Rights America normalizes whiteness, which expands the category white, but exposes non-whites to death or the risk of death. In this way, white normativity abandons non-whites to a state of war in which they must fend for themselves and battle one another in order to survive, while white America reaps the benefits of justice, peace, and security. Politics, in turn, becomes the activity of distinguishing among different forms of life, categorizing and ranking life experiences, and judging which lives are worth fostering and which are not. The basis for making such judgments is neither technical nor scientific.");
            isTalking = false;
            break;

            case "MandelaTalk":
            startTalking("Nelson Mandela was born on July 18, 1918, into a royal family of the Xhosa-speaking Thembu tribe in the South African village of Mvezo, where his father, Gadla Henry Mphakanyiswa (c. 1880-1928), served as chief. His mother, Nosekeni Fanny, was the third of Mphakanyiswa’s four wives, who together bore him nine daughters and four sons. After the death of his father in 1927, 9-year-old Mandela—then known by his birth name, Rolihlahla—was adopted by Jongintaba Dalindyebo, a high-ranking Thembu regent who began grooming his young ward for a role within the tribal leadership.");
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

    if(CurrentMTxt == "MandelaTalk"){
        Application.OpenURL("https://www.history.com/topics/africa/nelson-mandela ");
    
    } else if(CurrentMTxt == "GeorgeFTalk"){
        Application.OpenURL("https://www.bbc.co.uk/news/world-us-canada-52861726");
    
    } else if(CurrentMTxt == "MLKTalk"){
        Application.OpenURL("https://www.history.com/topics/black-history/martin-luther-king-jr ");
    
    } else if(CurrentMTxt == "MalcomeXTalk"){
        Application.OpenURL("https://www.google.co.uk/books/edition/The_Autobiography_of_Malcolm_X/EtVfCgAAQBAJ?hl=en");
    
    } else if(CurrentMTxt == "BloodPressureTalk"){
        Application.OpenURL(" https://doi.org/10.1177/0095798407307042 ");
    
    } else if(CurrentMTxt == "ColourismTalk"){
        Application.OpenURL("https://www.jstor.org/stable/26505337");
    
    } else if(CurrentMTxt == "MigrationTalk"){
        Application.OpenURL("https://doi.org/10.1080/09744053.2016.1239713");
    
    }else if(CurrentMTxt == "CanadaTalk"){
        Application.OpenURL("https://en.wikipedia.org/wiki/Slavery_in_Canada");
    
    }else if(CurrentMTxt == "LandTalk"){
        Application.OpenURL("https://www.jstor.org/stable/2256952?seq=1");
    
    }else if(CurrentMTxt == "TrustTalk"){
        Application.OpenURL("https://www.jstor.org/stable/41408736?seq=1");
    
    }else{
        OnlineExplore.SetActive(false);
    }

    }


    //additional resources BOOK 
public void ExternalBookMoreText(){
    if(CurrentMTxt == "MandelaTalk"){
        Application.OpenURL("https://www.amazon.co.uk/Long-Walk-Freedom-Autobiography-Mandela/dp/0349106533");
    
    } else if(CurrentMTxt == "GeorgeFTalk"){
        Application.OpenURL("https://www.google.co.uk/books/edition/Justice_for_George_Floyd/RTIPEAAAQBAJ?hl=en&gbpv=0 ");
    
    } else if(CurrentMTxt == "MLKTalk"){
        Application.OpenURL("https://www.amazon.co.uk/Autobiography-Martin-Luther-King-Jr/dp/0349112983");
    
    } else if(CurrentMTxt == "MalcomeXTalk"){
        Application.OpenURL("https://www.history.com/topics/black-history/malcolm-x");
    
    } else{
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