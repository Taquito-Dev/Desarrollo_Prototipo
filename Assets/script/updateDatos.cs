using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class updateDatos : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mostrar;
    [SerializeField] TextMeshProUGUI obtener;
    // Start is called before the first frame update
    void Start()
    {
       
        //print(mostrar.text);
        //print(obtener.text);
    }

    // Update is called once per frame
    void Update()
    {
         Mostrar();
    }

    public void Mostrar()
    {
        mostrar.text = obtener.text;
    }
}
