using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Igualar : MonoBehaviour
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
    int nR = 10;

    public void operation()
    {
        mal.SetActive(false);
        bien.SetActive(false);
        operacion = new string[20];
        respuesta = new string[20];
        operacion[0] = "50%";
        operacion[1] = "100%";
        operacion[2] = "25%";
        operacion[3] = "40%";
        operacion[4] = "80%";
        operacion[5] = "25%";
        operacion[6] = "100%";
        operacion[7] = "60%";
        operacion[8] = "25%";
        operacion[9] = "75%";
        operacion[10] = "70%";
        operacion[11] = "10%";
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

        if (problema <= 2)
        {
            m = Random.Range(0, 13);
            operaciontxt.text = operacion[m];
            Debug.Log("0 al 13");
        }
        else if (problema == 3)
        {
            m = Random.Range(14, 19);
            operaciontxt.text = operacion[m];
            Debug.Log("14 al 19");
        }
        else if (problema <= 1 & nR==11)
        {
            m = Random.Range(0, 13);
            operaciontxt.text = operacion[m];
            Debug.Log("0 al 13");
        }
        else if (problema >= 2 & nR == 11)
        {
            m = Random.Range(14, 19);
            operaciontxt.text = operacion[m];
            Debug.Log("14 al 19");
        }
        else if (problema >= 2 & nR == 12)
        {
            m = Random.Range(14, 19);
            operaciontxt.text = operacion[m];
            Debug.Log("14 al 19");
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

            problema++;
            if (problema >= 3)
            {
                SceneManager.LoadScene("MensajeBien");
                nR++;
                save.saveNivelReto4();
            }
            Invoke("operation", 2f);
        }
        else
        {
            mal.SetActive(true);
            bien.SetActive(false);
            Debug.Log("Respuesta Incorrecta");
            Invoke("operation", 2f);
        }

        //anim.SetBool("AD", false);
    }

    public void setNivelReto4(int nivelReto4)
    {
        nR = nivelReto4;
        Debug.Log(nR);

    }

    public int getNivelReto4()
    {
        return nR;
    }

    public void escena()
    {
        SceneManager.LoadScene("MensajeBien");
    }

    void Start()
    {
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
