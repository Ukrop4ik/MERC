using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public List<BattleUnit> MyUnits;
    public List<BattleUnit> EnemyUnits;

    void Awake()
    {

    }

    void Start()
    {

    }

    public void Setup(BattleUnit[] my, BattleUnit[] enemy)
    {
        Clear(MyUnits);
        Clear(EnemyUnits);
        MyUnits = my.ToList();
        EnemyUnits = enemy.ToList();
    }

    private static void Clear(List<BattleUnit> l)
    {
        foreach (var x in l)
            Destroy(x.gameObject);
        l.Clear();
    }

    public void UseAiForSolution()
    {
        foreach (var unit in MyUnits)
        {
            unit.Selection = EnemyUnits[Random.Range(0, EnemyUnits.Count)];
        }
    }

    public void CalculateDamages()
    {
        foreach (var unit in MyUnits)
        {
            Debug.Log(string.Format("{0} {1} calculate values of damages to {2} {3}", unit.name, unit.Unit.name, unit.Selection.name, unit.Selection.Unit.name));
        }
    }

    public void ApplyDamages()
    {

    }

}
