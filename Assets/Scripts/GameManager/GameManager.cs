using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        public List<Item> EquippedItems { get; }=new List<Item>();
        
        public Character(string name, string job, int level, int atk, int def, int hp, int maxhp, int sp, int gold) 
        {
            Name = name;
            Job = job;
            Level = level;
            Atk=atk;
            Def = def;
            Hp = hp;
            MaxHp = maxhp;
            Sp = sp;
            Gold = gold;
        }
        public void Equipitems(Item item)
        { 
            EquippedItems.Add(item);
            UpdateStatus();
        }
        public void UnEquipitems(Item item)
        {
            EquippedItems.Remove(item);
            UpdateStatus();
        }
        private void UpdateStatus()
        {
            if (Job == "Knights")
            { 
            
            }
            else if (Job =="Ranger")
            {
                
            }
            else if (Job == "Magician")
            {

            }

            foreach (Item item in EquippedItems)
            {
                if (item.Atk > 0)
                {
                    Atk += item.Atk;
                }
                else if (item.Def > 0)
                { 
                    Def += item.Def;
                }

            }
        }
    }
    public enum ItemType
    {
        Weapon,
        Armor
    }
    public class Item
    {
        public string Name { get; }
        public ItemType Type { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Price { get; }
        public string Explanation { get; }

        public Item(string name, ItemType type, int atk, int def, int price, string explanation)
        {
            Name = name;
            Type = type;
            Atk = atk;
            Def = def;
            Price = price;
            Explanation = explanation;
        }


    }

}
