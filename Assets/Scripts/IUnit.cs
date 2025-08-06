using UnityEngine;

public interface IUnit
{
    int AttackDamage { get; set; }
    void Walk();
    void Jump();
    void Die();
    void Damage();
}
