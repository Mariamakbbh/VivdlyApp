using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhanaMoreInfo : MonoBehaviour
{
    public GameObject BackgroundGhanaTexts;
    public GameObject SnakeMoreText;
    public GameObject KoraMoreText;
    public GameObject GriotMoreText;
    public GameObject DingaMoreText;
    public GameObject IslamMoreText;
    public GameObject GoldMoreText;
    public GameObject backblurr;
    bool isTalking;
    public static string currentTxt;

void Start(){
    isTalking = false;
    CloseMoreText();
}

//open additional info
public void BookMoreText(){
    BackgroundGhanaTexts.SetActive(true);
    backblurr.SetActive(true);
    
    switch(currentTxt)
        {
            case "snake":   
            FindObjectOfType<Ghana>().SnakeMoreText(false);
            stopTalking();
            SnakeMoreText.SetActive(true);
            currentTxt = "snake";
            isTalking = true;
            break;


            case "kora":
            FindObjectOfType<Ghana>().KoraMoreText(false);
            stopTalking();
            KoraMoreText.SetActive(true);
            currentTxt = "kora";
            isTalking = true;
            break;

            case "griot": 
            FindObjectOfType<Ghana>().GriotMoreText(false);
            stopTalking();
            GriotMoreText.SetActive(true);
            currentTxt = "griot";
            isTalking = true;
            break;


            case "dinga":
            FindObjectOfType<Ghana>().DingaMoreText(false);
            stopTalking();
            DingaMoreText.SetActive(true);
            currentTxt = "dinga";
            isTalking = true;
            break;

            case "islam":   
            FindObjectOfType<Ghana>().IslamMoreText(false);
            stopTalking();
            IslamMoreText.SetActive(true);
            currentTxt = "islam";
            isTalking = true;
            break;


            case "gold":
            FindObjectOfType<Ghana>().GoldMoreText(false);
            stopTalking();
            GoldMoreText.SetActive(true);
            currentTxt = "gold";
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
            case "snake":   
            CloseMoreText();
            FindObjectOfType<Ghana>().SnakeMoreText(true);
            break;


            case "kora":
            CloseMoreText();
            FindObjectOfType<Ghana>().KoraMoreText(true);
            break;

            case "griot": 
            CloseMoreText(); 
            FindObjectOfType<Ghana>().GriotMoreText(true);
            break;


            case "dinga":
            CloseMoreText();
            FindObjectOfType<Ghana>().DingaMoreText(true);
            break;

            case "islam":   
            CloseMoreText();
            FindObjectOfType<Ghana>().IslamMoreText(true);
            break;


            case "gold":
            CloseMoreText();
            FindObjectOfType<Ghana>().GoldMoreText(true);
            break;

            default:
            print("Nothing close"); 
            break;
        }
    }



//close all
public void CloseMoreText(){
    BackgroundGhanaTexts.SetActive(false);
    backblurr.SetActive(false);
    SnakeMoreText.SetActive(false);
    KoraMoreText.SetActive(false);
    GriotMoreText.SetActive(false);
    DingaMoreText.SetActive(false);
    IslamMoreText.SetActive(false);
    GoldMoreText.SetActive(false);
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
            case "snake":   
            startTalking("The wealth of Ghana is also explained mythically through the story of Bida, the black snake. The royal Sonnike people clung to their traditional beliefs, which included worship of Ouagadou-Bida, a great snake, which lived in a dark cave. When Diabe Cissé, son of  Dinga Cissé, arrived at the site where the town of Kumbi Saleh was to be established, he found it was guarded by a giant snake named Bida. In several versions of the legend, Bida is said to have lived in either a well or a cave. The great snake is usually thought of as a python. The python is a snake that often lives near streams and rivers, so having Bida take this form suggests the new settlement was located near water. Diabe Cissé entered into an agreement with the snake Bida. They agreed that Diabe Cissé could settle there and Bida would remain the guardian of the place. They also made a deal that every year the great snake would be given the most beautiful young virgin. In return, the snake demanded an annual sacrifice in return for guaranteeing prosperity in the kingdom. Every year a virgin was offered up, until one year, the fiancé of the intended victim, (his name was Mamadou Sarolle) rescued her. Cheated of his sacrifice, Bida took his revenge on the region. A terrible drought took hold of Ghana and gold mining fell into decline. Archaeologists have found evidence that confirms elements of the story, showing that until the 12th century, sheep and cows, as well goats, were abundant in the region. But after that only the tougher, more drought-resistant goats were common.");
            isTalking = false;
            break;


            case "kora":
            startTalking("The kora is made from a large gourd known as a calabash.  It is cut in half, emptied and dried and covered with animal skin. There are 21 strings which were originally made from animal hide and gut but now nylon line is used.  Some koras, particularly in the Casamance area of southern Senegal and in The Gambia, have an extra bass string so the 22 string kora is common there. Some kora players do use more, but this is relatively unusual.");
            isTalking = false;
            break;

            case "griot": 
            startTalking("Many cultures depend on oral history instead of written books to remember the past. In West Africa, oral histories are studied and constantly retold by professional historians - musicians called Griots (pronounced gree-oh). But in Mande culture they are called jeliw or jelilu (the singular is jeli). They are the artists responsible for maintaining the lively oral tradition that recalls the deeds of the early ancestors. Their storytelling keeps these ancestors and their actions alive in the community’s collective memory. As the main narrators of oral tradition, the jeliw or/ griots have been responsible for preserving stories that express what the Mande peoples believe happened in the distant past. Stories of the ancestors were passed from one generation of jeliw to the next, down through the centuries. The Mande aristocratic families frame their own identities by recounting how they descended from the ancestors described in these stories. As specialists in maintaining the oral history of their culture, jeliw are known to their own people as Guardians of the Word. The spoken word is believed to carry great power that can be a force for good or evil. In early times, the jeliw served as the spokespersons of chiefs and kings, and were therefore responsible for the reputation the king had in the community. Generations of jeli families were permanently attached to leading households and ruling dynasties. The rulers provided them with everything required to support their families in exchange for their services in the verbal arts. The jeliw fulfilled these responsibilities with praise songs and narratives describing the great deeds of the leader’s ancestors. Many play the Kora, a harp built out of a large, dry gourd. Oral histories about the origin of the Empire of Ghana begin with a story of the Soninke ancestor, Dinga.");
            isTalking = false;
            break;


            case "dinga":
            startTalking("Nobody is sure when Ghana came into being. But some time at the beginning of the first millennium AD, it is thought that a number of clans of the Soninke people, (in modern Senegal) came together under a leader with semi-divine status, called Dinga Cisse. According to legend, Dinga Cisse came from the east or somewhere in the Middle East. Some say he stayed for a time at Jenne, an ancient city that still exists on the Niger River north of Bamako, the capital of modern Mali. Dinga later moved to the town of Dia on the Inland Delta of the Niger. There, he married and had two sons. They became Soninke ancestors in other towns of the Sahel. He travelled a very long time to reach the place that would become Ghana. When Dinga and his family finally settled, they established a group of communities, each headed by one of Dinga’s sons. These communities prospered and grew into the first kingdom of ancient Soninke, named Ghana. Dinga’s movements from place to place are the storytellers’ way of explaining the presence of Soninke populations in various parts of the Sahel. Dinga is said to have eventually arrived at a place southwest of Nioro in today’s Mali. When he arrived there, it was dominated by genies, or spirits, of the bush. Various versions of the legend describe a kind of magician’s duel that took place between Dinga and the genies. Dinga won the contest and married the three daughters of the chief genie. Their sons became the ancestors of many Soninke clans. One clan was the Cissé. It was the Cissé that became the ruling clan of Wagadu. In the next episode in the legend, Dinga had grown old and blind. He decided that before he died, he wanted to pass his chiefly power on to his oldest son, Khiné. But a younger son named Diabe Cissé disguised himself as the oldest brother and tricked his father into giving him the chiefly powers. According to one version of the story, after Dinga died, Diabe Cissé had to run away from his angry older brother. He hid in the wilderness, find out more about him by clicking the snake.");
            isTalking = false;
            break;

            case "islam":   
            startTalking("Before the arrival of Islam and Christianity in Africa, the great pythons were sacred religious symbols throughout sub-Saharan West Africa, from the Sahel to the Atlantic coast. So it is not difficult to see how the idea of the great snake as a highly spiritual water guardian could develop. Inevitably traders brought Islam with them. Initially, the Islamic community at Kumbi Saleh (Capital City of Ancient Ghana) remained a separate community some distance away from the king's palace. It had its own mosques and schools. But, the king retained his traditional beliefs. He drew on the book-keeping and literary skills of Muslim scholars to help run the administration of the territory. The state of Takrur to the west had already adopted Islam as its official religion and evolved ever closer trading ties with North Africa. In 1056, when the Almoravids captured Awdaghust from Ghana, the Zanata merchants there were punished for having cooperated with the Soninke. Many Soninke of Ghana had held on to their traditional religious rituals with the sacred serpent and other spirits. But because of the powerful Almoravid influence, in the following years they were converted, sometimes by force, to Islam.");
            isTalking = false;
            break;


            case "gold":
            startTalking("What is clear, is that the Empire derived power and wealth from gold. And the introduction of the camel in the Trans-Saharan trade boosted the amount of goods that could be transported. Most of our knowledge of Ghana comes from Arab writers. Al-Hamdani, for example, describes Ghana as having the richest gold mines on earth and Ghana being a mysterious place of darkness where there were “waters that make the gold grow”. These were situated at Bambuk, on the upper Senegal River. The Soninke also sold slaves, salt and copper, in exchange for textiles, beads and finished goods. The capital of Kumbi Saleh became the focus of all trade, with a systematic form of taxation. Later Audaghust was another commercial centre.");
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
            case "snake":   
            Application.OpenURL("https://www.youtube.com/watch?v=DPrJVyTs2Kc");
            break;

            case "kora":
            Application.OpenURL("https://www.youtube.com/watch?v=-cLAwAOi-hA");
            break;

            case "griot": 
            Application.OpenURL("https://www.youtube.com/watch?v=jdxKQkcCtpQ");
            break;

            case "dinga":
            Application.OpenURL("https://www.blackpast.org/global-african-history/ghana-ca-750-1076/#:~:text=Dinga%20Cisse%20is%20considered%20the,emerging%20Trans%2DSaharan%20trade%20routes.&text=They%20sought%20both%20to%20make,lucrative%20Trans%2DSaharan%20trade%20routes.");
            break;

            case "islam":   
            Application.OpenURL("https://www.ancient.eu/Ghana_Empire/#:~:text=Islam%20was%20spread%20throughout%20the,the%20elite%20of%20urban%20areas.&text=Indeed%2C%20in%20the%20Ghana%20Empire,kings%20themselves%20converted%20to%20Islam.");
            break;

            case "gold":
            Application.OpenURL("https://www.ancient.eu/Ghana_Empire/#:~:text=Islam%20was%20spread%20throughout%20the,the%20elite%20of%20urban%20areas.&text=Indeed%2C%20in%20the%20Ghana%20Empire,kings%20themselves%20converted%20to%20Islam.");
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
