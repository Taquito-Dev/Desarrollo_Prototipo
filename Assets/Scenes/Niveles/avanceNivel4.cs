using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanceNivel4 : MonoBehaviour
{
    public saveSystem save;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;
    public static int nr;
    // Start is called before the first frame update
    void Start()
    {
        nr =save.snr();
        Debug.Log(nr);
        switch(nr){
            case 10:
                puerta2.SetActive(true);
            break;
            case 11:
                puerta2.SetActive(true);
                puerta3.SetActive(true);
            break;
            case 12:
                puerta2.SetActive(true);
                puerta3.SetActive(true);
                puerta4.SetActive(true);
            break;
        }
        if(nr>12){
             puerta2.SetActive(true);
                puerta3.SetActive(true);
                puerta4.SetActive(true);
           }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
