using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanceNivel3 : MonoBehaviour
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
            case 7:
                puerta2.SetActive(true);
            break;
            case 8:
                puerta2.SetActive(true);
                puerta3.SetActive(true);
            break;
            case 9:
                puerta2.SetActive(true);
                puerta3.SetActive(true);
                puerta4.SetActive(true);
            break;
        }
        if(nr>9){
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
