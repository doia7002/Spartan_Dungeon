using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatPopUp : Stat
{
    [SerializeField] Text nameText;
    [SerializeField] Text hpText;
    [SerializeField] Text atkText;
    [SerializeField] Text speedText;
    [SerializeField] Text spText;

    public void ShowStat(Stat stat)
    {
        nameText.text = stat.Name;
        hpText.text = $"HP: {stat.Hp} / {stat.MaxHp}";
        atkText.text = $"Atk: {stat.Atk}";
        speedText.text = $"Speed: {stat.Speed}";
        spText.text = $"Sp: {stat.Sp}";
    }

    public void ShowKnightStat()
    {
        Stat stat = new Stat().SetUnitStat(UnitCode.Knight);
        ShowStat(stat);
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowKnightStat();
    }
}
