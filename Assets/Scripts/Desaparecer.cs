using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Desaparecer : MonoBehaviour
{

    public GameObject microescopio;
    //public questionSelector nR;
    public saveSystem save;

    public static int nR;

    // Start is called before the first frame update
    void Start()
    {
        
        nR = save.snr();
        if(nR == 1)
        {
            microescopio.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        microescopio.SetActive(false);
    }
}
