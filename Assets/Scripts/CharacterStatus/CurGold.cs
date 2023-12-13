using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurGold : Stat
{
    [SerializeField] Text Goldtext;

    public void ShowStat(Stat stat)
    { 
        Goldtext.text = $"Gold: {stat.Gold}";
    }
    public void Gold()
    {
        Stat stat = new Stat().SetUnitStat(UnitCode.Knight);
        ShowStat(stat);
    }
    void Start()
    {
        Gold();
    }
}
