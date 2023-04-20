using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Nivel3Reto2 : MonoBehaviour
{
    public string[] operacion;
    public string[] respuesta;
    public int m;
    int nr=0;

    //public GameObject operacionCanvas;
    public GameObject plataforma;
    public colocarPlano _colocarPlano;
    public dropPlanos _dropPlanos;

    public GameObject[] imagenes;

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

    public saveSystem save;

    int inco = 0;

    public void operation(){
        mal.SetActive(false);
        bien.SetActive(false);
        operacion =new string[6];
        respuesta=new string[6];
        //nivel 2
        
        //reto 2
        operacion[0]="(1/6)+(3/2)";
        operacion[1]="(3/3)-(2/2)";
        operacion[2]="(6/7)-(1/2)";
        operacion[3]="(11/3)-(2/1)";
        operacion[4]="(7/8)-(3/8)";
        operacion[5]="(1/2)+(1/3)";
        
        respuesta[0]="10/6";
        respuesta[1]="0";
        respuesta[2]="5/14";
        respuesta[3]="5/3";
        respuesta[4]="4/8";
        respuesta[5]="5/6";
       
        //m = 19;
        m=Random.Range(0,6);
        operaciontxt.text=operacion[m];
        imagenes[m].gameObject.SetActive(true);
        Debug.Log(m);
    }

    public void comparacion(){

       
        switch(m){
            
            case 0:
            respuestaCorrecta= 10f/6f;
                Debug.Log("caso 7");
                break;
            case 1:
            respuestaCorrecta= 0f;
                Debug.Log("caso 8");
                break;
            case 2:
            respuestaCorrecta= 5f/14f;
                Debug.Log("caso 9");
                break;
            case 3:
            respuestaCorrecta= 5f/3f;
                Debug.Log("caso 10");
                break;
            case 4:
            respuestaCorrecta= .5f;
                Debug.Log("caso 11");
                break;
            case 5:
            respuestaCorrecta= 5f/6f;
                Debug.Log("caso 12");
                break;
            

        }
        respuestaUsuario=numeradorS.value/denominadorS.value;
        Debug.Log(respuestaCorrecta);
        Debug.Log(respuestaUsuario);

        if(respuestaUsuario==respuestaCorrecta){
            Debug.Log("Respues correcta");
            bien.SetActive(true);
            mal.SetActive(false);

            plataforma.gameObject.SetActive(true);
            _colocarPlano.DesactivarCanvas();
            _dropPlanos.GenerarPlano();
            _dropPlanos.GeneraPlanoDoblado();
            imagenes[m].gameObject.SetActive(false);

            problema++;
            if (problema >= 5)
            {
                SceneManager.LoadScene("Nivel3_Bien1");
                if(nr<8){
                    nr=8;
                    save.saveNL(nr);
                }
            }
           
            Invoke("operation", 2f);
        }
        else{
            inco++;
            mal.SetActive(true);
            bien.SetActive(false);
            Debug.Log("Respuesta Incorrecta");
            Invoke("operation",2f);
            imagenes[m].gameObject.SetActive(false);
        }
        if (inco == 3)
        {

            SceneManager.LoadScene("Nivel3_Mal1");
        }
    }

    void Start(){
        operation();
         nr=save.snr();
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