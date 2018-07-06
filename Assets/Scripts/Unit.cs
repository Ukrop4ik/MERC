using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    [SerializeField]
    private UnitStats unitStats;

	void Start ()
    {
		
	}

    [System.Serializable]
    public class UnitStats
    {
        //ActualStats
        public int CurrentHp = 0;

        //Generic Stats
        public int UnitMaxHp = 0;
        public int UnitArmor = 0;
        public int UnitMaxDamage = 0;
        public int UnitMinDamage = 0;

        //primary stats
        public string UnitName = "";
        public int Strength = 0; 
        public int Constitution = 0;
        public int Dexterity = 0;
        public int Intelligence = 0;

        public Weapon UnitWeapon;

        public UnitStats(string unitName, int strength, int constitution, int dexterity, int intelligence)
        {
            UnitName = unitName;
            Strength = strength;
            Constitution = constitution;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void CreateUnitStat()
        {
            UnitMaxHp = Constitution * 10;
            CurrentHp = UnitMaxHp;
            UnitMaxDamage = UnitWeapon.MaxDamage * Strength;
            UnitMinDamage = UnitWeapon.MinDamage * Strength;

        }
    }
}
