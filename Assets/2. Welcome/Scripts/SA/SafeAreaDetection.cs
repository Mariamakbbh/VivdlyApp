using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaDetection : MonoBehaviour
{
    public delegate void SafeAreaChanged(Rect safeArea);
    public static event SafeAreaChanged OnSafeAreaChanged;
    private Rect mysafeArea;

    private void Start() {
        mysafeArea = Screen.safeArea;

    }

    private void Update() {
        mysafeArea = Screen.safeArea;
        if(mysafeArea != Screen.safeArea){
            mysafeArea = Screen.safeArea;
            OnSafeAreaChanged?.Invoke(mysafeArea);
        }
    }
}
