using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class InstructionsController : MonoBehaviour
{
    public UnityEvent talkEvent;
    public UnityEvent notTalkEvent;


    public static bool IsOn;
    
      void Start()
      {
          IsOn = false;
      }

    public void InstuctionsTalk(){
        if (!IsOn)
        {
        IsOn = true;
        talkEvent?.Invoke();
        

        }else {
           IsOn = false; 
           notTalkEvent?.Invoke();
           
        }
    }

        public void InstuctionsOFF(){
           notTalkEvent?.Invoke();
           
        }
        

    
}
