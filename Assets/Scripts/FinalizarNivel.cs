using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalizarNivel : MonoBehaviour
{
    public saveSystem save;
    int reto;

    // Start is called before the first frame update
    void Start()
    {
        save.loadNivelRetoMenu();
    }

    public void setNivel(int retos)
    {
        reto = retos;
        Debug.Log(reto);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
