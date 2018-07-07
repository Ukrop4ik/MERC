using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTest : MonoBehaviour
{
    public Battle Battle;

    public Weaponary Weaponary;
    public Tavern Tavern;

    public Container Player;
    public Container Enemy;
    
    void Awake()
    {
        
    }

    void Start()
    {
        Mock();
    }

    void Mock()
    {
        Player.Add(Weaponary.Spawn("RawSword"));
        Player.Add(Weaponary.Spawn("RawSword"));
        Player.Add(Weaponary.Spawn("RawBow"));

        Player.Add(Tavern.Spawn("Grimm"));
        Player.Add(Tavern.Spawn("Digger"));
        Player.Add(Tavern.Spawn("Elven"));

        Player.Equip(0, 0);
        Player.Equip(1, 1);
        Player.Equip(2, 2);

        Enemy.Add(Weaponary.Spawn("RawSword"));
        Enemy.Add(Weaponary.Spawn("RawSword"));
        Enemy.Add(Weaponary.Spawn("RawSword"));
        Enemy.Add(Weaponary.Spawn("RawSword"));

        Enemy.Add(Tavern.Spawn("Random"));
        Enemy.Add(Tavern.Spawn("Random"));
        Enemy.Add(Tavern.Spawn("Random"));

        var items = new int[] {0,1,2,3};
        Shuffle(items);

        Enemy.Equip(0, items[0]);
        Enemy.Equip(1, items[1]);
        Enemy.Equip(2, items[2]);

        Battle.Setup(Player, Enemy);

        Battle.PlayerArmy.UseAiForSolution();
        Battle.EnemyArmy.UseAiForSolution();

        Battle.MakeStep();
    }

    public static void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            int k = Random.Range(0, n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }

}
