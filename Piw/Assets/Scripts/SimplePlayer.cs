using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayer : MonoBehaviour
{
    public int moedas = 0;
    
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

        if (Keyboard.current.uKey.wasPressedThisFrame)
        {
            UndoLastCommand();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            MyCommandManager.AddCommand(new GetCoin(other.gameObject, player:this));
            MyCommandManager.DoCommand();
            //moedas++;
            //Destroy(other.gameObject);
        }
    }

    public void UndoLastCommand()
    {
        MyCommandManager.UndoCommand();
    }
    
}
