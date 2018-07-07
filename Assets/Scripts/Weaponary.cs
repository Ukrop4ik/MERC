using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponary : MonoBehaviour
{
    public List<Weapon> Prototypes;
    public Transform Pool;

    private Spawner<Weapon> _spawner;

    void Awake()
    {
        _spawner = new Spawner<Weapon>(Pool, Prototypes);
    }

    void Start()
    {

    }

    public Weapon Spawn(string name)
    {
        var weapon = _spawner.Spawn(name);

        return weapon;
    }

}
