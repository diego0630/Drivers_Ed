using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DamageGauge
{
    public static int damage = 10;
    
    public static void Minus(int amount)
    {
        damage -= amount;
    }
    
    public static string GetDamage()
    {
        return damage.ToString();
    }
    
    public static int GetDamageAsInt()
    {
        return damage;
    }
    
    public static void Replenish()
    {
        damage = 10;
    }
}
