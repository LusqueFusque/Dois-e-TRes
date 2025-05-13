using UnityEngine;

public class Door : MonoBehaviour
{
    private string listeningButtonID;
    private Collider2D doorCollider;
    private SpriteRenderer doorSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        doorCollider = GetComponent<Collider2D>();
        doorSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        StaticEventChannel.OnButtonPressed += OnButtonPressed;
    }

    private void OnDisable()
    {
        StaticEventChannel.OnButtonPressed -= OnButtonPressed;
    }

    private void OnButtonPressed(string buttonID)
    {
        if (buttonID == listeningButtonID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        Debug.Log($"Door for {listeningButtonID} opened!");
        doorCollider.enabled = false;
        doorSprite.color = new Color(1, 1, 1, 0.3f); // feedback
    }
}


