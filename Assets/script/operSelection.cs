using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class operSelection : MonoBehaviour
{
    public string[] operacion;
    public string[] respuesta;
    public int m;

    [SerializeField] TextMeshProUGUI denominador;
    [SerializeField] TextMeshProUGUI numerador;
    [SerializeField] TextMeshProUGUI operaciontxt;

    public float respuestaCorrecta;
    public string respuestaTemp;
    public float respuestaUsuario;
    public float denominadorValue;
    public float numeradorValue;


    [SerializeField] Slider numeradorS;
    [SerializeField] Slider denominadorS;

    int problema = 0;
    public GameObject bien;
    public GameObject mal;

    public void operation(){
        mal.SetActive(false);
        bien.SetActive(false);
        operacion =new string[20];
        respuesta=new string[20];
        operacion[0]="(16/5)+(4/5)";
        operacion[1]="(6/5)+(2/5)";
        operacion[2]="(7/2)+(4/2)";
        operacion[3]="(1/5)+(4/5)";
        operacion[4]="(2/4)+(3/4)";
        operacion[5]="(2/4)+(1/4)";
        operacion[6]="(1/6)+(3/6)";
        operacion[7]="(2/3)+(3/3)";
        operacion[8]="(6/2)+(4/2)-(1/2)";
        operacion[9]="(11/3)-(5/3)";
        operacion[10]="(3/8)-(1/8)";
        operacion[11]="(2/9)+(3/9)";
        operacion[12]="(2/7)+(1/7)";
        operacion[13]="(7/6)-(3/6)";
        operacion[14]="(2/3)-(2/3)";
        operacion[15]="(8/5)-(3/5)";
        operacion[16]="(2/8)+(1/8)-(1/8)";
        operacion[17]="(9/4)-(8/1)";
        operacion[18]="(12/1)-(2/1)";
        operacion[19]="(1/4)+(6/4)-(3/4)";

        respuesta[0]="12/5";
        respuesta[1]="8/5";
        respuesta[2]="3/2";
        respuesta[3]="5/5";
        respuesta[4]="5/4";
        respuesta[5]="3/4";
        respuesta[6]="4/6";
        respuesta[7]="5/3";
        respuesta[8]="9/2";
        respuesta[9]="6/3";
        respuesta[10]="2/8";
        respuesta[11]="5/9";
        respuesta[12]="3/7";
        respuesta[13]="4/6";
        respuesta[14]="0";
        respuesta[15]="5/5";
        respuesta[16]="2/8";
        respuesta[17]="1/4";
        respuesta[18]="10";
        respuesta[19]="4/4";
     
        
        m=Random.Range(0,19);
        operaciontxt.text=operacion[m];
        Debug.Log(m);
    }

    public void comparacion(){

       
        switch(m){
            case 0:
            respuestaCorrecta=2.4f;
                Debug.Log("caso 1");
                break;
            case 1:
            respuestaCorrecta=1.6f;
                Debug.Log("caso 2");
                break;
            case 2:
            respuestaCorrecta=1.5f;
                Debug.Log("caso 3");
                break;
            case 3:
            respuestaCorrecta=1f;
                Debug.Log("caso 4");
                break;
            case 4:
            respuestaCorrecta=1.25f;
                Debug.Log("caso 5");
                break;
            case 5:
            respuestaCorrecta=0.75f;
                Debug.Log("caso 6");
                break;
            case 6:
            respuestaCorrecta= 0.6666667f;
                Debug.Log("caso 7");
                break;
            case 7:
            respuestaCorrecta= 1.666666667f;
                Debug.Log("caso 8");
                break;
            case 8:
            respuestaCorrecta=4.5f;
                Debug.Log("caso 9");
                break;
            case 9:
            respuestaCorrecta= 2f;
                Debug.Log("caso 10");
                break;
            case 10:
            respuestaCorrecta=0.25f;
                Debug.Log("caso 11");
                break;
            case 11:
            respuestaCorrecta=0.5555556f;
                Debug.Log("caso 12");
                break;
            case 12:
            respuestaCorrecta= 0.4285714f;
                Debug.Log("caso 13");
                break;
            case 13:
            respuestaCorrecta=0.6666667f;
                Debug.Log("caso 14");
                break;
            case 14:
            respuestaCorrecta=0f;
                Debug.Log("caso 15");
                break;
            case 15:
            respuestaCorrecta=1f;
                Debug.Log("caso 16");
                break;
            case 16:
            respuestaCorrecta=0.25f;
                Debug.Log("caso 17");
                break;
            case 17:
            respuestaCorrecta=0.25f;
                Debug.Log("caso 18");
                break;
            case 18:
            respuestaCorrecta=10f;
                Debug.Log("caso 19");
                break;
            case 19:
            respuestaCorrecta=1f;
                Debug.Log("caso 20");
                break;

        }
        respuestaUsuario=numeradorS.value/denominadorS.value;
        Debug.Log(respuestaCorrecta);
        Debug.Log(respuestaUsuario);

        if(respuestaUsuario==respuestaCorrecta){
            Debug.Log("Respues correcta");
            bien.SetActive(true);
            mal.SetActive(false);

            problema++;
            if (problema >= 10)
            {
                SceneManager.LoadScene("Reto");
            }
            Invoke("operation", 2f);
        }
        else{
            mal.SetActive(true);
            bien.SetActive(false);
            Debug.Log("Respuesta Incorrecta");
            Invoke("operation",2f);
        }
    }

    void Start(){
        operation();
    }
    // Update is called once per frame
    void Update()
    {

        denominadorValue=denominadorS.value;
        numeradorValue=numeradorS.value;
        denominador.text=denominadorValue.ToString();
        numerador.text=numeradorValue.ToString();
        
    }
}
