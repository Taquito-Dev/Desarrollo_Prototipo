using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Nivel1Reto3 : MonoBehaviour
{
    public Slider decimadorN;
    public Slider decimadorD;

    public GameObject grupo1 ;
    public GameObject grupo2 ;

    public int intentosCo;
    public int intentosIn;

    public GameObject imgBien;
    public GameObject imgMal;

    public GameObject[]objectsToInstantiate;
    GameObject temp;
    public Transform pos;
    public GameObject imagenFrac;

    public TMP_Text numerador;
    public TMP_Text denominador;

    public float[] respuestas;
    public float respuesta;

    List<int> numerosDisponibles = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

    public int n=-1;
    public int nr;

    public saveSystem save;
    
    // Variables para almacenar el número de sliders con valor 1
    float numSlidersGrupo1 = 0f;
    float numSlidersGrupo2 = 0f;


    // Start is called before the first frame update
    void Start()
    {
        randomProblem();
        temp = Instantiate(objectsToInstantiate[n]);
    }

    // Update is called once per frame
    void Update()
    {
        numerador.text=numSlidersGrupo1.ToString();
        denominador.text=numSlidersGrupo2.ToString();    
        if(intentosCo>5){
            SceneManager.LoadScene("MensajeBien");
            if(nr<3){
                nr=3;
                save.saveNL(nr);
            }
        }
        if(intentosIn>3){
            SceneManager.LoadScene("MensajeMal");
        } 
    }
    void randomProblem(){
        //n=Random.Range(0,7);
        
        if (numerosDisponibles.Count > 0)
        {
            int indiceAleatorio = Random.Range(0, numerosDisponibles.Count);
            n = numerosDisponibles[indiceAleatorio];
            numerosDisponibles.RemoveAt(indiceAleatorio);
        }

        respuestas= new float[8];
        respuestas[0]=0.8f;
        respuestas[1]=0.1111111111f;
        respuestas[2]=.25f;
        respuestas[3]=0.7f;
        respuestas[4]=0.75f;
        respuestas[5]=0.25f;
        respuestas[6]=1.75f;
        respuestas[7]=1.25f;

        imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
        imagenFrac.transform.parent=pos.transform;
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
    }

    public void readSliders(){
        numSlidersGrupo1=0f;
        numSlidersGrupo2=0f;       
            if(decimadorN.value==1){
                numSlidersGrupo1=10f;
            }
            if(decimadorD.value==1){
                numSlidersGrupo2=10f;
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
        float respuestaUs=numSlidersGrupo1/numSlidersGrupo2;
        Debug.Log("usuario:"+respuestaUs);
        Debug.Log("correcta"+respuesta);
         Destroy(imagenFrac);
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
