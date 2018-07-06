using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public enum WeaponType
    {
        Sword,
        Arrow,
        Staff
    }
    public int Range;
    public int MinDamage;
    public int MaxDamage;
    public WeaponType Type;
}
