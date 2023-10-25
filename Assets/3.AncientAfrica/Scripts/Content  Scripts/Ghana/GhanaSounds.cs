using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhanaSounds : MonoBehaviour
{ //took this script from my gaming coursework, changed it a bit to match ghana sounds 

    public Music[] sounds; 
    public static bool stop;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Music s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
           s.source.loop = s.loop;
        }
        
    }

     public void PlayDrums(){
         stop = false;
        PlaySound("Drums");
    }

    public void StopSound(string name)
    {
        
        foreach (Music s in sounds)
        {
           if(s.name == name){
               if(s.source.isPlaying == true){
                   s.source.mute = false;
                   s.source.Stop();
               }else if (s.source.mute == true){
                   s.source.mute = false;
                   s.source.Stop();
               }
               
           }
        }
    }
    public void PlayandMute(string name)
    {
        
        foreach (Music s in sounds)
        {
           if(s.name == name){
               if(s.source.isPlaying == false){
                   s.source.Play();
                  s.source.mute = true;   
               }
               
           }
        }
    }

    public void MuteSound(string name)
    {
        foreach (Music s in sounds)
        {
           if(s.name == name){
               s.source.mute = true;
           }
        }
    }

    public void Unmute(string name)
    {
        foreach (Music s in sounds)
        {
           if(s.name == name){
               s.source.mute = false;
           }
        }
    }
    

   public void PlaySound(string name)
    {
        
        foreach (Music s in sounds)
        {
           if(s.name == name){
               if(s.source.mute == true){
                   s.source.mute = false; 
               }else{
                s.source.Play();
               s.source.mute = false;   
               }
               
           }
        }
    }

    public void PlaySoundifnotPlaying(string name)
    {
        foreach (Music s in sounds)
        {
           if(s.name == name){
               if(s.source.isPlaying == true){
                   s.source.mute = false;
               }else{
               s.source.Play();
               s.source.mute = false;
               }
           }
        }
    }
}

