using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject itemToAdd;
    public int amountToAdd;

    Inventory inventory;
    GameManagerSingleton gameManager;

    private void Start()
    {
        gameManager = GameManagerSingleton.instance;
        inventory = gameManager.GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider collection)
    {
        if (collection.CompareTag("Player"))
        {

            inventory.CheckSlotsAvailability(itemToAdd, itemToAdd.name, amountToAdd);

            Destroy(gameObject);
        }
    }
}
