using System;
using UnityEngine;

public class Player : MonoBehaviour, IUnit
{
    public int AttackDamage { get; set; }

    private void Start()
    {
        Walk();
    }

    private void Update()
    {
        
    }

    public void Walk()
    {
        if(Input.GetKey(KeyCode.T))
        Debug.Log("Walk");
        Debug.Log("¿öÅ©");
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

   
}
