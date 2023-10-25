using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaPanel : MonoBehaviour
{
    private RectTransform MyrectTransfrom;

    private void Start() {
       MyrectTransfrom = GetComponent<RectTransform>();
       RefreshPanel(Screen.safeArea);
    }
    void Update(){

        RefreshPanel(Screen.safeArea);
    }

    private void OnEnable() {
        SafeAreaDetection.OnSafeAreaChanged += RefreshPanel;
    }

    private void OnDisable() {
       SafeAreaDetection.OnSafeAreaChanged -= RefreshPanel; 
    }


    public void RefreshPanel(Rect safeArea)
    {
        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        MyrectTransfrom.anchorMin = anchorMin;
        MyrectTransfrom.anchorMax = anchorMax;
    }
}
