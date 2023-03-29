using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LastLevel1 : MonoBehaviour
{
    // Buscar los grupos de sliders en la escena
    public Slider decimadorN;
    public Slider decimadorD;
    public GameObject grupo1 ;
    public GameObject grupo2 ;
    public int intentosCo;
    public int intentosIn;

    public GameObject imgBien;
    public GameObject imgMal;

    public saveSystem save;

    public Transform pos;
    
    public GameObject[] imagenes;
    
    public float[] respuestas;
    public float respuesta;
    public TMP_Text numerador;
    public TMP_Text denominador;
    
    public int n=-1;
     List<int> numerosDisponibles = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
    public int nr=4;


    // Variables para almacenar el número de sliders con valor 1
    float numSlidersGrupo1 = 0f;
    float numSlidersGrupo2 = 0f;

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

    // Start is called before the first frame update
    void Start()
    {
        randomPanel();
        nr=save.snr();
    }

    public void randomPanel(){
        /* n= 7; */
        if (numerosDisponibles.Count > 0)
          {
            int indiceAleatorio = Random.Range(0, numerosDisponibles.Count);
            n = numerosDisponibles[indiceAleatorio];
            numerosDisponibles.RemoveAt(indiceAleatorio);
          }
        respuestas= new float[20];       
        respuestas[0]=.333333333f;
        respuestas[1]=.3f; 
        respuestas[2]=.166666667f;
        respuestas[3]=.266666667f;
        respuestas[4]=1f;
        respuestas[5]=.75f;
        respuestas[6]=.388888889f;
        respuestas[7]=.333333333f;
       
       imagenes[n].gameObject.SetActive(true);
        

       /*  imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
        imagenFrac.transform.parent=pos.transform; */
       
        respuesta=respuestas[n];
        Debug.Log(n);
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
    public void RespuestaUsuario(){
        float respuestaUs=0f;
        if(numSlidersGrupo1!=0 || numSlidersGrupo2!=0){
            respuestaUs=numSlidersGrupo1/numSlidersGrupo2;
        }
        Debug.Log(respuestaUs);
        Debug.Log(respuesta);
        if(respuestaUs==respuesta){
            imgBien.SetActive(true);
            Invoke("randomPanel",3f);
            intentosCo++;
        }
        else{
            imgMal.SetActive(true);
             Invoke("randomPanel",3f);
             intentosIn++;
        }
        imagenes[n].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        numerador.text=numSlidersGrupo1.ToString();
        denominador.text=numSlidersGrupo2.ToString();    

        if(intentosCo>5){
            SceneManager.LoadScene("MensajeBien");
            if(nr<5){
                nr=5;
                save.saveNL(nr);
            }
        }
        if(intentosIn>3){
            SceneManager.LoadScene("MensajeMal");
        }    
    }
}
