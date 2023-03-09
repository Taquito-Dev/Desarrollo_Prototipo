using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalizarNivel : MonoBehaviour
{
    public saveSystem save;
    public TMP_Text completado;
    int reto;
    public questionSelector nR;

    public GameObject item2;

    // Start is called before the first frame update
    void Start()
    {
        item2.SetActive(false);
        save.loadNivelRetoMenu();

        if(questionSelector.nR==4)
        {
            item2.SetActive(true);
        }
    }

    public void setNivel(int retos)
    {
        reto = retos;
        Debug.Log(reto);

        switch(reto=0){
            case 1: 
            completado.text="30% Completado";
            break;
            case 2:
            completado.text="60% Completado";
            break;
            case 3:
            completado.text="100% Completado";
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
