using System;
using UnityEngine;

public class StaticEventChannel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public static Action<string> OnButtonPressed;
    
        public static void ButtonPressed(string buttonID)
        {
            OnButtonPressed?.Invoke(buttonID);
        }
}
