using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour//,IDamage
{
    public int speed;
    public int health;

    public abstract void Attack();
    public virtual void Die()
    {
        Debug.Log("I am dead");
    }
}

public class Robot : Enemy
{
    public override void Attack()
    {

    }
    public override void Die()
    {
        base.Die();
    }

    //  void Damage(10)
    //{
    //    Debug.Log("The passed Value :");
    //}
}