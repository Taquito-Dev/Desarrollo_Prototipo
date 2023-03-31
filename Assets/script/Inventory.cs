using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{

    
    public GameObject[] slots;
    public GameObject[] backPack;
    private bool isInstantiated;
    TextMeshProUGUI text;

    private bool inventoryEnabled;
    public GameObject inventory;

    public Dictionary<string, int> inventoryItems = new Dictionary<string, int>();


    

    public void CheckSlotsAvailability(GameObject itemToAdd, string itemName, int itemAmount)
    {
        isInstantiated = false;
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].transform.childCount>0)
            {
                slots[i].GetComponent<SlotScript>().isUsed = true;
            }
            else 
            {
                //Crear el item en el slot vacio
                if (!inventoryItems.ContainsKey(itemName))
                {
                    GameObject item = Instantiate (itemToAdd, slots[i].transform.position, Quaternion.identity);
                    item.transform.SetParent(slots[i].transform, false);
                    item.transform.localPosition = new Vector3(0, 0, 0);
                    item.name = item.name.Replace("(Clone)", "");
                    isInstantiated = true;
                    slots[i].GetComponent<SlotScript>().isUsed = true;
                    inventoryItems.Add(itemName, itemAmount);

                    text = slots[i].GetComponentInChildren<TextMeshProUGUI>();
                    text.text = itemAmount.ToString();
                    break;
                }
                else
                {
                    
                }
            }
        }
    } 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
            Debug.Log("I was pressed");
        
            if (inventoryEnabled == true)
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
            }
        } 
        
    } 
}
