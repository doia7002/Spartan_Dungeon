using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public GameObject InventoryPopUp;
    public GameObject ShopPopUp;
    public GameObject StatusPopUp;
    public bool Status;
    public bool Shop;
    public bool Inventory;

    
    public void VeiwStatus()
    {
        StatusPopUp.SetActive(true);
        Status = false;
        Shop = false;
        Inventory = false;
        
    }
    public void VeiwShop() 
    {
        ShopPopUp.SetActive(true);
        Shop = false;
        Inventory = false;
        Status = false;
    }
    public void VeiwInventory()
    {
        InventoryPopUp.SetActive(true);
        Inventory = false;
        Status = false;
        Shop = false;
    }
    public void ExitPopUp()
    {
        if (StatusPopUp == true)
        {
            StatusPopUp.SetActive(false);
        }
        else if (ShopPopUp == true)
        {
            ShopPopUp.SetActive(false);
        }
        else if (InventoryPopUp == true)
        { 
            InventoryPopUp.SetActive(false);
        }
    
    }

}
