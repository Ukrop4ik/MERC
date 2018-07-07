using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    [System.Serializable]
    public class Config
    {
        public int RangeFromOrigin;
    }

    public Config UnitConfig;
    public Unit Unit;

    public BattleUnit Selection;

    void Awake()
    {

    }

    void Start()
    {

    }

}
