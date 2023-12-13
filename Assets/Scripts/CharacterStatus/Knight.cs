using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public Stat stat;
    public UnitCode unitCode;
    // Start is called before the first frame update
    void Start()
    {
        stat=new Stat();
        stat=stat.SetUnitStat(UnitCode.Knight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
