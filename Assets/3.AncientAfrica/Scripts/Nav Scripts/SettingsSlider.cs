using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSlider : MonoBehaviour
{
    public GameObject settMenu;
  //  public GameObject settIcon;

    // Start is called before the first frame update
    void Start()
    {
    Animator anim = settMenu.GetComponent<Animator>();
    bool isOpen = anim.GetBool("Sdisplay");
    anim.SetBool("Sdisplay", !isOpen);
   // settIcon.SetActive(false);
        
    }

    // Update is called once per frame
    public void displaySettings(){
        
        if (settMenu != null)
        {
            
            Animator anim = settMenu.GetComponent<Animator>();
            if (anim != null)
            {  // settIcon.SetActive(true);           
                bool isOpen = anim.GetBool("Sdisplay");
                anim.SetBool("Sdisplay", !isOpen);
                
            }
        }
    }
}

