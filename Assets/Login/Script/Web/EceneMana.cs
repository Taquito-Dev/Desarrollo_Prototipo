using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EceneMana : MonoBehaviour
{
    public GameObject registrar;
    public GameObject login;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activar()
    {
        registrar.SetActive(true);
    }

    public void desactivar()
    {
        login.SetActive(false);
    }

}
