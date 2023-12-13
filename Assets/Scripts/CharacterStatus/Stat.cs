using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitCode
{ 
    Knight
}

public class Stat : MonoBehaviour
{
    public UnitCode unitCode { get; }
    public string Name { get; set; }
    public int MaxHp { get; set; }
    public int Hp { get; set; }
    public int Atk { get; set; }
    public int Speed { get; set; }
    public int Sp { get; set; }
    public int Gold {  get; set; }

    public Stat()
    { }

    public Stat(UnitCode unitCode, string name, int maxhp, int hp, int atk, int speed, int sp,int gold)
    { 
        this.unitCode = unitCode;
        this.Name = name;
        this.MaxHp = maxhp;
        Hp = MaxHp;
        
        this.Atk = atk;
        this.Speed = speed;
        this.Sp = sp;
        this.Gold = gold;
    }
    public Stat SetUnitStat(UnitCode unitCode)
    {
        Stat stat = null;

        switch (unitCode) 
        {
            case UnitCode.Knight:
                stat = new Stat(unitCode, "Knight", 50, 10, 5, 5, 5, 2000);
                break;
        }
        return stat;
    }
}
