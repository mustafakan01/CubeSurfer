using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable,IKillable
{
    private int health;
    public void Damage(int damageTaken)
    {
        health = damageTaken;
    }

    public void Kill()
    {
        health = 0;
    }
}
