using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayer : MonoBehaviour
{
    public int moedas;
    
    public CommandManager MyCommandManager;
    private void Start()
    {
        MyCommandManager = new CommandManager();
    }
    
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            MyCommandManager.AddCommand(new MoveUp(transform));
            MyCommandManager.DoCommand();
            //transform.position += Vector3.up;
        }
        
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            MyCommandManager.AddCommand(new MoveRight(transform));
            MyCommandManager.DoCommand();
            //transform.position += Vector3.right;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            moedas++;
            Destroy(other.gameObject);
        }
    }
}
