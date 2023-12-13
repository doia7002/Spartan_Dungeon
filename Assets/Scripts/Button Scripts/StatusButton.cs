using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusButton : MonoBehaviour
{
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
    public void PopUpView()
    { 
        StatusPopUp.SetActive(true);
        Status.SetActive(false);
        Shop.SetActive(false);
        Inventory.SetActive(false);
    }
}
