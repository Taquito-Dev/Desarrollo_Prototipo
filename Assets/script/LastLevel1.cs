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

    public GameObject[]objectsToInstantiate;
    public Transform pos;
    public GameObject imagenFrac;
    public string[] problemas;
    public float[] respuestas;
    public float respuesta;
    public TMP_Text numerador;
    public TMP_Text denominador;
    public TMP_Text problema;
    public int n;
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
        n= Random.Range(0,19);
        respuestas= new float[20];
        problemas= new string[20];
        
        respuestas[0]=1.2f;
        respuestas[1]=.25f;
        respuestas[2]=.1875f;
        respuestas[3]=.5f;
        respuestas[4]=1.5f;
        respuestas[5]=1.6f;
        respuestas[6]=.333333f;
        respuestas[7]=.15f;
        respuestas[8]=1.2f;   
        respuestas[9]=.5f;
        respuestas[10]=.0555555556f;	
        respuestas[11]=1f;
        respuestas[12]=.333333333f;
        respuestas[13]=.3f; 
        respuestas[14]=.166666667f;
        respuestas[15]=.266666667f;
        respuestas[16]=1f;
        respuestas[17]=.75f;
        respuestas[18]=.388888889f;
        respuestas[19]=.333333333f;
       
        problemas[0]="6─5*5─5";
        problemas[1]="1─5*10─8";
        problemas[2]="1─2*3─8";
        problemas[3]="1─5*5─2";
        problemas[4]="6─5÷5─5";
        problemas[5]="1─5÷1─8";
        problemas[6]="1─2÷3─2";
        problemas[7]="1─5÷4─3";
        problemas[8]="7─5-1─2*2─5";   
        problemas[9]="1─2*2─4+1─4";
        problemas[10]="1─6÷3─2-1─18";      	
        problemas[11]="2─3÷3─4+1─9";
        problemas[12]="1─2*1─3÷1─2";
        problemas[13]="1─5*1─2+2─10";    	        
        problemas[14]="1─2÷3─2-1─6";
        problemas[15]="1─5*4─3";
        problemas[16]="4─5-1─2+2─5";
        problemas[17]="1─2+2─4-1─4";
        problemas[18]="1─6+1─2-1─12";
        problemas[19]="3─3-3─4+1─12";

        

       /*  imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
        imagenFrac.transform.parent=pos.transform; */
        problema.text=problemas[n];
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
    }
    public void RespuestaUsuario(){
        float respuestaUs=numSlidersGrupo1/numSlidersGrupo2;
        Debug.Log(respuestaUs);
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
