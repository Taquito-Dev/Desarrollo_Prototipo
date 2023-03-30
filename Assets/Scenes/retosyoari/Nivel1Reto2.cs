using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Nivel1Reto2 : MonoBehaviour
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
       
        //reto 2
        operacion[0]="4─7";
        operacion[1]="1─5";
        operacion[2]="6─6";   
        operacion[3]="3─8";
        operacion[4]="2─6";      	
        operacion[5]="4─6";
        

        respuesta[0]="4─7";
        respuesta[1]="1─5";
        respuesta[2]="6─6";   
        respuesta[3]="3─8";
        respuesta[4]="2─6";      	
        respuesta[5]="4─6";

        //m = 19;
        m=Random.Range(0,6);
        operaciontxt.text=operacion[m];
        imagenes[m].gameObject.SetActive(true);
        Debug.Log(m);
    }

    public void comparacion(){

       
        switch(m){
            case 0:
            respuestaCorrecta=4f/7f;
                Debug.Log("caso 1");
                break;
            case 1:
            respuestaCorrecta=0.2f;
                Debug.Log("caso 2");
                break;
            case 2:
            respuestaCorrecta=1f;
                Debug.Log("caso 3");
                break;
            case 3:
            respuestaCorrecta=0.375f;
                Debug.Log("caso 4");
                break;
            case 4:
            respuestaCorrecta=2f/6f;
                Debug.Log("caso 5");
                break;
            case 5:
            respuestaCorrecta= 4f/6f;
                Debug.Log("caso 6");
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
                SceneManager.LoadScene("GameScene");
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