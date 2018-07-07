using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    public List<Unit> Prototypes;
    public Transform Pool;

    private Spawner<Unit> _spawner;

    void Awake()
    {
        _spawner = new Spawner<Unit>(Pool, Prototypes);
    }

    void Start()
    {

    }

    public Unit Spawn(string name)
    {
        var unit = _spawner.Spawn(name);

        unit.Generate();

        return unit;
    }

}
