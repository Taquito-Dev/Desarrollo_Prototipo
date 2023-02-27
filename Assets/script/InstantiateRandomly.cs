using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    public Transform posit;
    public Transform transit;
    public GameObject[] objectsToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateObject()
    {
       int n = Random.Range(0, objectsToInstantiate.Length);

        //Instantiate(objectsToInstantiate[n], posit.position, objectsToInstantiate[n].transform.rotation);

        Instantiate(objectsToInstantiate[n], new Vector3(0.4941642f, -0.5f, -4.200538f), posit.transform.rotation);
        //Instantiate(objectsToInstantiate[0], new Vector3(-8f, 1f, -.24f), posit.transform.rotation);
       
        //{
            //int n = Random.Range(0, objectsToInstantiate.Length);
            //Instantiate(objectsToInstantiate[n], new Vector3(0.4941642f, -0.5f, -4.200538f), objectsToInstantiate[n].transform.rotation);
        //}

    }
}
