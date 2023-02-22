using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropPlanos : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;
    public int frac;
    public Transform pos;


    // Start is called before the first frame update
    void Start()
    {
        GenerarPlano();
    }
    public void GenerarPlano()
    {
        Instantiate(objectsToInstantiate[0], new Vector3(-1.397f, 1.031937f, -8.319f), pos.transform.rotation);
        //for (int i = 0; i < 8; i++)
        //{
        //    frac = Random.Range(0, objectsToInstantiate.Length);
        //    Instantiate(objectsToInstantiate[frac], new Vector3(-7f + i * .8f, 1f, -.24f), pos.transform.rotation);
        //}
    }



    // Update is called once per frame
    void Update()
    {

    }
}
