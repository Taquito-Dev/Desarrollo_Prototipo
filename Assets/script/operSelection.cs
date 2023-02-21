using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class operSelection : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI denominador;
    [SerializeField] TextMeshProUGUI numerador;
    public float denominadorValue;
    public float numeradorValue;


    [SerializeField] Slider numeradorS;
    [SerializeField] Slider denominadorS;




    // Update is called once per frame
    void Update()
    {

        denominadorValue=denominadorS.value;
        numeradorValue=numeradorS.value;
        denominador.text=denominadorValue.ToString();
        numerador.text=numeradorValue.ToString();
        
    }
}
