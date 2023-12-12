using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public class Character
    { 
        public string Name { get; set; }
        public string Job { get; set; }
        public int Level { get; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Sp { get; set; }
        public int Gold { get; set; }
        public List<item> EquippedItems { get; }=new List<item>();
    }
}
