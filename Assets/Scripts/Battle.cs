using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public List<BattleUnit> Slots;
    public Army PlayerArmy;
    public Army EnemyArmy;

    public Transform Pool;

    private Spawner<BattleUnit> _spawner;

    void Awake()
    {
        _spawner = new Spawner<BattleUnit>(Pool, Slots);
    }

    void Start()
    {
        
    }

    public void Setup(Container player, Container enemy)
    {
        // battle model construction, matching positions, setup refs
        var leftSlots = new BattleUnit[] { _spawner.Spawn("L1"), _spawner.Spawn("L2"), _spawner.Spawn("L3") };
        var rightSlots = new BattleUnit[] { _spawner.Spawn("R1"), _spawner.Spawn("R2"), _spawner.Spawn("R3") };

        leftSlots[0].Unit = player.Units[0];
        leftSlots[1].Unit = player.Units[1];
        leftSlots[2].Unit = player.Units[2];

        rightSlots[0].Unit = enemy.Units[0];
        rightSlots[1].Unit = enemy.Units[1];
        rightSlots[2].Unit = enemy.Units[2];

        PlayerArmy.Setup(leftSlots, rightSlots);
        EnemyArmy.Setup(rightSlots, leftSlots);
    }

    public void MakeStep()
    {
        PlayerArmy.CalculateDamages();
        EnemyArmy.CalculateDamages();

        PlayerArmy.ApplyDamages();
        EnemyArmy.ApplyDamages();
    }

}
