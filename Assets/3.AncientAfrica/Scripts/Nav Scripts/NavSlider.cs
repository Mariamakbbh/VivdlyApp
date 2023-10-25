using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavSlider : MonoBehaviour
{
    public GameObject NavMenu;
    

 void Start() {
     

    Animator anim = NavMenu.GetComponent<Animator>();
     bool isOpen = anim.GetBool("display");
     anim.SetBool("display", !isOpen);
}

    public void displayNav(){
        if (NavMenu != null)
        {
            Animator anim = NavMenu.GetComponent<Animator>();
            if (anim != null)
            {
                bool isOpen = anim.GetBool("display");
                anim.SetBool("display", !isOpen);
            }
        }
    }



    


}
