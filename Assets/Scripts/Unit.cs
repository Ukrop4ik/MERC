using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [System.Serializable]
    public class GenericInfo
    {
        public int MinStrength, MaxStrength;
        public int MinConstitution, MaxConstitution;
        public int MinDexterity, MaxDexterity;
        public int MinIntelligence, MaxIntelligence;

        public int MinStartHpPrc, MaxStartHpPrc;
    }

    [System.Serializable]
    public class UnitStats
    {
        //primary stats
        public int Strength = 0;
        public int Constitution = 0;
        public int Dexterity = 0;
        public int Intelligence = 0;

        //ActualStats
        public int CurrentHp = 0;

        public int MaxHp { get { return Constitution*10; } }
    }

    public string UnitName = "";
    public GenericInfo Generic;
    public UnitStats Stats;

    public Weapon RightHandWeapon;

    public int ContainerId = -1;

    void Awake()
    {

    }

    void Start()
    {

    }

    public void Generate()
    {
        Stats.Strength = Random.Range(Generic.MinStrength, Generic.MaxStrength+1);
        Stats.Constitution = Random.Range(Generic.MinConstitution, Generic.MaxConstitution+1);
        Stats.Dexterity = Random.Range(Generic.MinDexterity, Generic.MaxDexterity+1);
        Stats.Intelligence = Random.Range(Generic.MinIntelligence, Generic.MaxIntelligence+1);

        Stats.CurrentHp = Stats.MaxHp * Random.Range(Generic.MinStartHpPrc, Generic.MaxStartHpPrc+1) / 100;
    }

}
