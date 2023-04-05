using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Nivel4Reto3 : MonoBehaviour
{
    public Slider decimadorN;
    public Slider decimadorD;

    public GameObject grupo1 ;
    public GameObject grupo2 ;

    public int intentosCo;
    public int intentosIn;

    public GameObject imgBien;
    public GameObject imgMal;

    //public GameObject[]objectsToInstantiate;
    
    GameObject temp;
    public Transform pos;
    

    public TMP_Text numerador;
    public TMP_Text denominador;

    public TMP_Text operacionTemp;
    public string[] operacion;
    public string opera;
    public float[] respuestas;
    public float respuesta;

    List<int> numerosDisponibles = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

    public int n=-1;
    public int nr=1;

    public saveSystem save;
    
    // Variables para almacenar el número de sliders con valor 1
    float numSlidersGrupo1 = 0f;
    float numSlidersGrupo2 = 0f;


    // Start is called before the first frame update
    void Start()
    {
        randomProblem();
    }

    // Update is called once per frame
    void Update()
    {
        numerador.text=numSlidersGrupo1.ToString();
        denominador.text=numSlidersGrupo2.ToString();    
        if(intentosCo>2){
            SceneManager.LoadScene("Nivel4_Bien1");
            if(nr<12){
                nr=12;
                save.saveNL(nr);
            }
        }
        if(intentosIn>3){
            SceneManager.LoadScene("Nivel4_Mal1");
        } 
    }
    void randomProblem(){
        //n=0;
        operacion = new string[8];
        if (numerosDisponibles.Count > 0)
        {
            int indiceAleatorio = Random.Range(0, numerosDisponibles.Count);
            n = numerosDisponibles[indiceAleatorio];
            numerosDisponibles.RemoveAt(indiceAleatorio);
        }

        operacion[0] = "60%";
        operacion[1] = "20%";
        operacion[2] = "45%";
        operacion[3] = "125%";
        operacion[4] = "175%";
        operacion[5] = "5%";
        operacion[6] = "12.5%";
        operacion[7] = "87.5%";

        respuestas= new float[8];
        respuestas[0]=0.6f;
        respuestas[1]=0.2f;
        respuestas[2]=0.45f;
        respuestas[3]=1.25f;
        respuestas[4]=1.75f;
        respuestas[5]=0.05f;
        respuestas[6]=0.125f;
        respuestas[7]=0.875f;

        opera=operacion[n];
        respuesta=respuestas[n];
        imgBien.SetActive(false);
        imgMal.SetActive(false);
        foreach (Slider slider in grupo1.GetComponentsInChildren<Slider>()) {
            slider.value = 0;
        }
        // Recorrer todos los sliders del grupo 2 y contar los que tienen valor 1
        foreach (Slider slider in grupo2.GetComponentsInChildren<Slider>()) {
           slider.value =0;
        }
        decimadorN.value=0;
        decimadorD.value=0;
        operacionTemp.text=opera;
    }

    public void readSliders(){
        numSlidersGrupo1=0f;
        numSlidersGrupo2=0f;       
            if(decimadorN.value==1){
                numSlidersGrupo1=10f;
            }
            if(decimadorN.value==2){
                numSlidersGrupo1=20f;
            }
            if(decimadorD.value==1){
                numSlidersGrupo2=10f;
            }
            if(decimadorD.value==2){
                numSlidersGrupo2=20f;
            }
        // Recorrer todos los sliders del grupo 1 y contar los que tienen valor 1
        foreach (Slider slider in grupo1.GetComponentsInChildren<Slider>()) {
            if (slider.value == 1) {
                numSlidersGrupo1++;               
            }
        }
        // Recorrer todos los sliders del grupo 2 y contar los que tienen valor 1
        foreach (Slider slider in grupo2.GetComponentsInChildren<Slider>()) {
            if (slider.value == 1) {
                numSlidersGrupo2++;            
            }
        }
        // Imprimir el número de sliders con valor 1 en cada grupo
        /*   Debug.Log("Número de sliders con valor 1 en grupo 1: " + numSlidersGrupo1);
        Debug.Log("Número de sliders con valor 1 en grupo 2: " + numSlidersGrupo2); */
    }  
    public void RespuestaUsuario(){
        float respuestaUs=0f;
        if(numSlidersGrupo1!=0 || numSlidersGrupo2!=0){
            respuestaUs=numSlidersGrupo1/numSlidersGrupo2;
        }
        Debug.Log("usuario:"+respuestaUs);
        Debug.Log("correcta"+respuesta);    
        if(respuestaUs==respuesta){
           imgBien.SetActive(true);
           Debug.Log("correcto");
           Invoke("randomProblem",3f);
           intentosCo++;
        }
        else{
            imgMal.SetActive(true);
            Debug.Log("incorrecto");
            Invoke("randomProblem",3f);
            intentosIn++;
        }
       
    }
}
