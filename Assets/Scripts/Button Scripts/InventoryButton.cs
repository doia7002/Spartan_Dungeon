using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject InventoryPopUp;
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
    public void PopUpView()
    {
        InventoryPopUp.SetActive(true);
        Status.SetActive(false);
        Shop.SetActive(false);
        Inventory.SetActive(false);
    }
}
