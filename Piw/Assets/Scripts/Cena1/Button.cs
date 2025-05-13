using UnityEngine;

public class Button : MonoBehaviour
{
    private string buttonID;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Button {buttonID} pressed!");
            StaticEventChannel.ButtonPressed(buttonID);
        }
    }
}
