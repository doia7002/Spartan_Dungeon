using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    public GameObject InventoryPopUp;
    public GameObject ShopPopUp;
    public GameObject StatusPopUp;
    public GameObject Status;
    public GameObject Shop;
    public GameObject Inventory;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PopUpVCancle()
    {
        if (InventoryPopUp == true)
        {
            InventoryPopUp.SetActive(false);
            ShopPopUp.SetActive(false);
            StatusPopUp.SetActive(false);
            Inventory.SetActive(true);
            Shop.SetActive(true);
            Status.SetActive(true);
        }
        else if (ShopPopUp == true)
        {
            ShopPopUp.SetActive(false);
            InventoryPopUp.SetActive(false);
            StatusPopUp.SetActive(false);
            Inventory.SetActive(true);
            Shop.SetActive(true);
            Status.SetActive(true);
        }
        else if (StatusPopUp == true)
        { 
            StatusPopUp.SetActive(false);
            InventoryPopUp.SetActive(false);
            ShopPopUp.SetActive(false);
            Inventory.SetActive(true);
            Shop.SetActive(true);
            Status.SetActive(true);
        }
    }
}
