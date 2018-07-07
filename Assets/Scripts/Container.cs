using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public List<Unit> Units;
    public List<Weapon> Weapons;

    public List<Weapon> Free;
    public List<Weapon> Equiped;

    void Awake()
    {

    }

    void Start()
    {

    }

    public void Add(Unit unit)
    {
        unit.ContainerId = Units.Count;
        Units.Add(unit);
    }

    public void Add(Weapon weapon)
    {
        weapon.ContainerId = Weapons.Count;
        Weapons.Add(weapon);
        Free.Add(weapon);
        Equiped.Add(null);
    }

    public void Equip(int unitContainerId, int weaponContainerId)
    {
        var weapon = Free[weaponContainerId];
        Equiped[weaponContainerId] = weapon;
        Free[weaponContainerId] = null;
        Units[unitContainerId].RightHandWeapon = weapon;
    }

}
