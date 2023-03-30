using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Nivel4Reto2 : MonoBehaviour
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
        operacion =new string[20];
        respuesta=new string[20];
        //nivel 4
        //reto 1
        operacion[0] = "50%";
        operacion[1] = "100%";
        operacion[2] = "25%";
        operacion[3] = "40%";
        operacion[4] = "80%";
        operacion[5] = "25%";
        //reto 2 
        operacion[6] = "100%";
        operacion[7] = "60%";
        operacion[8] = "25%";
        operacion[9] = "75%";
        operacion[10] = "70%";
        operacion[11] = "10%";
        //reto 3
        operacion[12] = "60%";
        operacion[13] = "20%";
        operacion[14] = "66%";
        operacion[15] = "125%";
        operacion[16] = "175%";
        operacion[17] = "5%";
        operacion[18] = "12.5%";
        operacion[19] = "87.5%";

        respuesta[0] = "12/5";
        respuesta[1] = "8/5";
        respuesta[2] = "3/2";
        respuesta[3] = "5/5";
        respuesta[4] = "5/4";
        respuesta[5] = "3/4";
        respuesta[6] = "4/6";
        respuesta[7] = "5/3";
        respuesta[8] = "9/2";
        respuesta[9] = "6/3";
        respuesta[10] = "2/8";
        respuesta[11] = "5/9";
        respuesta[12] = "3/7";
        respuesta[13] = "4/6";
        respuesta[14] = "0";
        respuesta[15] = "5/5";
        respuesta[16] = "2/8";
        respuesta[17] = "1/4";
        respuesta[18] = "10";
        respuesta[19] = "4/4";

        //m = 19;
        m=Random.Range(6,12);
        operaciontxt.text=operacion[m];
        imagenes[m].gameObject.SetActive(true);
        Debug.Log(m);
    }

    public void comparacion(){

       
        switch(m){
            case 0:
                respuestaCorrecta = 0.5f;
                Debug.Log("caso 1");
                break;
            case 1:
                respuestaCorrecta = 1f;
                Debug.Log("caso 2");
                break;
            case 2:
                respuestaCorrecta = 0.25f;
                Debug.Log("caso 3");
                break;
            case 3:
                respuestaCorrecta = 0.4f;
                Debug.Log("caso 4");
                break;
            case 4:
                respuestaCorrecta = 0.8f;
                Debug.Log("caso 5");
                break;
            case 5:
                respuestaCorrecta = 0.25f;
                Debug.Log("caso 6");
                break;
            case 6:
                respuestaCorrecta = 1f;
                Debug.Log("caso 7");
                break;
            case 7:
                respuestaCorrecta = 0.6f;
                Debug.Log("caso 8");
                break;
            case 8:
                respuestaCorrecta = 0.25f;
                Debug.Log("caso 9");
                break;
            case 9:
                respuestaCorrecta = 0.75f;
                Debug.Log("caso 10");
                break;
            case 10:
                respuestaCorrecta = 0.7f;
                Debug.Log("caso 11");
                break;
            case 11:
                respuestaCorrecta = 0.1f;
                Debug.Log("caso 12");
                break;
            case 12:
                respuestaCorrecta = 0.6f;
                Debug.Log("caso 13");
                break;
            case 13:
                respuestaCorrecta = 0.2f;
                Debug.Log("caso 14");
                break;
            case 14:
                respuestaCorrecta = 0.6666667f;
                Debug.Log("caso 15");
                break;
            case 15:
                respuestaCorrecta = 1.25f;
                Debug.Log("caso 16");
                break;
            case 16:
                respuestaCorrecta = 1.75f;
                Debug.Log("caso 17");
                break;
            case 17:
                respuestaCorrecta = 0.05f;
                Debug.Log("caso 18");
                break;
            case 18:
                respuestaCorrecta = 0.125f;
                Debug.Log("caso 19");
                break;
            case 19:
                respuestaCorrecta = 0.75f;
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

            plataforma.gameObject.SetActive(true);
            _colocarPlano.DesactivarCanvas();
            _dropPlanos.GenerarPlano();
            _dropPlanos.GeneraPlanoDoblado();
            imagenes[m].gameObject.SetActive(false);

            problema++;
            if (problema >= 5)
            {
                SceneManager.LoadScene("MensajeBien");
                if(nr<3){
                    nr=3;
                    save.saveNL(nr);
                }
            }
            if (inco == 3)
            {
                
                SceneManager.LoadScene("MensajeMal"); 
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