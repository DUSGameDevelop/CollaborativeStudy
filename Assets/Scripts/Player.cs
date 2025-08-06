using System;
using UnityEngine;

public class Player : MonoBehaviour, IUnit
{
    public int AttackDamage { get; set; }

    private void Start()
    {
        
    }

    private void Update()
    {
        Walk();
    }

    public void Walk()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
           Debug.Log("esc 누름");
       }
    }
    
    public void Jump()
    {
        Debug.Log("Jump");
    }
    
    public void Die()
    {
        Debug.Log("Die");
    }
    
    public void Damage()
    {
        Debug.Log("Damage");
    }

    
    public void TestCallWon()
    {
        Debug.Log("Won");
    }


}
