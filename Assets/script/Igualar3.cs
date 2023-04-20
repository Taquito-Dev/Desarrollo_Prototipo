﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.Animations;

public class Igualar3 : MonoBehaviour
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

    [SerializeField] TMP_InputField numeradorI;
    [SerializeField] TMP_InputField denominadorI;

    float num;
    float deno;

    public Animator anim;

    public saveSystem save;
    int nR = 6;

    public GameObject zero;
    public GameObject uno;
    public GameObject dos;
    public GameObject tres;
    public GameObject cuatro;
    public GameObject cinco;
    int malres = 0;

    public void operation()
    {
        mal.SetActive(false);
        bien.SetActive(false);
        operacion = new string[20];
        respuesta = new string[20];
        operacion[0] = "(4/5)-(2/3)";
        operacion[1] = "(6/5)+(3/3)";
        operacion[2] = "(7/2)-(3/3)";
        operacion[3] = "(1/5)+(2/1)";
        operacion[4] = "(1/4)+(1/5)";
        operacion[5] = "(2/3)+(1/4)";
        

        respuesta[0] = "2/15";
        respuesta[1] = "11/5";
        respuesta[2] = "5/2";
        respuesta[3] = "11/5";
        respuesta[4] = "24/4";
        respuesta[5] = "11/4";
     

        if (problema <= 3 )
        {
            m = Random.Range(0, 6);
            switch (m)
            {
                case 0:
                    zero.SetActive(true);
                    break;
                case 1:
                    uno.SetActive(true);
                    break;
                case 2:
                    dos.SetActive(true);
                    break;
                case 3:
                    tres.SetActive(true);
                    break;
                case 4:
                    cuatro.SetActive(true);
                    break;
                case 5:
                    cinco.SetActive(true);
                    break;

            }
            //operaciontxt.text = operacion[m];
            Debug.Log("false");    
        }
            

        //m = Random.Range(0, 19);
        //operaciontxt.text = operacion[m];
        Debug.Log(m);
        anim.SetBool("AD", false);
    }

    public void comparacion()
    {
        num = float.Parse(numeradorI.text);
        deno = float.Parse(denominadorI.text);

        

        switch (m)
        {
            case 0:
                respuestaCorrecta = 0.13333334f;
                Debug.Log("caso 0");
                zero.SetActive(true);
                break;
            case 1:
                respuestaCorrecta = 2.2f;
                Debug.Log("caso 1");
                uno.SetActive(true);
                break;
            case 2:
                respuestaCorrecta = 2.5f;
                Debug.Log("caso 2");
                dos.SetActive(true);
                break;
            case 3:
                respuestaCorrecta = 2.2f;
                Debug.Log("caso 3");
                tres.SetActive(true);
                break;
            case 4:
                respuestaCorrecta = 6f;
                Debug.Log("caso 4");
                cuatro.SetActive(true);
                break;
            case 5:
                respuestaCorrecta = 2.75f;
                Debug.Log("caso 5");
                cinco.SetActive(true);
                break;

        }
        //respuestaUsuario = numeradorS.value / denominadorS.value;

        respuestaUsuario = num / deno;
        Debug.Log(respuestaCorrecta);
        Debug.Log(respuestaUsuario);

        if (respuestaUsuario == respuestaCorrecta)
        {
            Debug.Log("Respues correcta");
            bien.SetActive(true);
            mal.SetActive(false);
            anim.SetBool("AD", true);

            zero.SetActive(false);
            uno.SetActive(false);
            dos.SetActive(false);
            tres.SetActive(false);
            cuatro.SetActive(false);
            cinco.SetActive(false);

            problema++;
            if (problema >= 3)
            {
                SceneManager.LoadScene("Nivel3_Bien1");               
                 if(nR<7){
                    nR=7;
                    save.saveNL(nR);
                }
            }
            Invoke("operation", 2f);
        }
        else if (malres < 3)
        {
            malres++;
            mal.SetActive(true);
            bien.SetActive(false);
            Debug.Log("Respuesta Incorrecta");
            Invoke("operation", 2f);

            zero.SetActive(false);
            uno.SetActive(false);
            dos.SetActive(false);
            tres.SetActive(false);
            cuatro.SetActive(false);
            cinco.SetActive(false);
        }
        else if (malres == 3)
        {
            SceneManager.LoadScene("Nivel3_Mal1");
        }

        //anim.SetBool("AD", false);
    }

    public void escena()
    {
        SceneManager.LoadScene("MensajeBien");
    }

    void Start()
    {
        
        zero.SetActive(false);
        uno.SetActive(false);
        dos.SetActive(false);
        tres.SetActive(false);
        cuatro.SetActive(false);
        cinco.SetActive(false);
        operation();
        //anim = gameObject.GetComponent<Animator>();
        save.loadNivelReto4();
 
    }
    // Update is called once per frame
    void Update()
    {

        //denominadorValue = denominadorS.value;
       // numeradorValue = numeradorS.value;
        //denominador.text = denominadorValue.ToString();
        //numerador.text = numeradorValue.ToString();

    }
}
