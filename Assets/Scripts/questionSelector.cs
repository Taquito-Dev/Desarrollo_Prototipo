using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using TMPro;

public class questionSelector : MonoBehaviour
{
    
    public saveSystem save;
    
    public Text problemlabel;
    public Transform pos;
    public string[] problemasTry;
    public string[] problemas; //Arreglo que contendra las respuestas de la pirmera pregunta
    int  problema = 0; //Variable que obtendra un elemento del arreglo
    public GameObject ButtonstoInstantiate;
    public GameObject[]objectsToInstantiate;
    public GameObject bien;
    public GameObject mal;
    GameObject temp;
    GameObject temp2;
    public GameObject buttonFrac;
    public GameObject imagenFrac;
    public int intentos;

    float time;
    float timeDelay;
    public static int nR =0;

    public TMP_Text puntos;
    
    public int n;
   
    void awake(){ 
       
       /*  save=FindObjectOfType<saveSystem>(); */
    }
    void Start()
    {
        nR=save.snr();
        randomButtons();        
        temp = Instantiate(objectsToInstantiate[n]);
        temp2 = Instantiate(ButtonstoInstantiate);
        //mal.SetActive(false);
        //bien.SetActive(false);


        //nR = 0;
        //save.saveNL(nR);
        //Descomentar esta codigo y ejecutar el videojuego para reiniciar el reto

    }
    public void setNivelReto(int nivelReto){
        nR=nivelReto;
        Debug.Log(nR);
       
    }
    public void instantiateObject(){
        Debug.Log("Objeto"+n);
    }
    public void randomButtons(){
        
    problemas= new string[20];
    problemasTry= new string[4];
   //reto 1
    problemas[0]="1─2";
    problemas[1]="3─3";
    problemas[2]="1─3";
    problemas[3]="1─8";
    problemas[4]="1─4";
    problemas[5]="2─5";
    //reto2
    problemas[6]="4─7";
    problemas[7]="1─5";
    problemas[8]="6─6";   
    problemas[9]="3─8";
    problemas[10]="2─6";      	
    problemas[11]="4─6";
    //reto 6
    problemas[12]="4─5";
    problemas[13]="1─9";    	        
    problemas[14]="3─12";
    problemas[15]="7─10";
    problemas[16]="6─8";
    problemas[17]="2─8";
    problemas[18]="7─4";
    problemas[19]="10─8";


        problemasTry[0]=""; 
        problemasTry[1]="";
        problemasTry[2]="";
        problemasTry[3]="";
        
        
        bool repetido=false;
        int indice=0;
        int m=Random.Range(0,4);
        
        while(indice<problemasTry.Length){
            repetido=false;
            /* switch(nR){
                case 1:
                Debug.Log("Reto 1");
                n= Random.Range(0,5);
                break;
                case 2:
                Debug.Log("Reto 2");
                n= Random.Range(6,11);
                break;
                case 3:
                Debug.Log("Reto 3");
                n= Random.Range(12,19);
                break;
                default:
                n=Random.Range(0,19);
                break;
            } */
            n= Random.Range(0,19); 
            for(int j=0; j<problemasTry.Length ;j++)
            {                
                if (problemasTry[j]==problemas[n]){
                        repetido=true;
                    }
            }
                if(!repetido){
                    problemasTry[indice]=problemas[n];
                    buttonFrac = Instantiate(ButtonstoInstantiate,  new Vector2((indice+1)*350,50), pos.transform.rotation) as GameObject;  
                    buttonFrac.name = ("button"+indice.ToString());
                    GameObject.Find("button"+indice.ToString()).GetComponentInChildren<Text>().text = problemasTry[indice];
                    buttonFrac.transform.parent=pos.transform;
                    
                    if (indice==m){
                        imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
                        imagenFrac.transform.parent=pos.transform;
                    
                        buttonFrac.GetComponent<Button>().onClick.AddListener(() => Invoke("seleccion", 1.0f));                        
                    
                }else{
                    buttonFrac.GetComponent<Button>().onClick.AddListener(() => Invoke("malSeleccion", 1.0f));
                }
                    indice++;
                }
        }
        
    }

    public void seleccion()
    {
        bien.SetActive(true);
        
        mal.SetActive(false);
        //SceneManager.LoadScene("seleccion");

        for (int h = 0; h < 4; h++)
        {
            Destroy(buttonFrac = GameObject.Find("button" + h.ToString()));
            buttonFrac.name = "";
        }
        problema = problema + 1;
        puntos.text = problema.ToString();
        print(problema);
        Invoke("eliminar", 1.0f);
        print("Bien");
    }

    public void malSeleccion()
    {
        mal.SetActive(true);
        for (int h = 0; h < 4; h++)
        {
            Destroy(buttonFrac = GameObject.Find("button" + h.ToString()));
            buttonFrac.name = "";
        }
        // SceneManager.LoadScene("seleccion");
        Invoke("eliminar", 1.0f);
        print("Respuesta equivocada intenta otra vez");
        if(nR==3){
            intentos++;
            if(intentos==3){
                Debug.Log("Lo siento, intenta el nivel de nuevo");
                nR=1;
                save.saveNL(nR);
                SceneManager.LoadScene("MensajeMal");
            }
        }
    }

    public void eliminar()
    {
        mal.SetActive(false);
        bien.SetActive(false);
        Destroy(imagenFrac);
        randomButtons();

        //Destroy(buttonFrac);
      
    }

    public void escena()
    {
        SceneManager.LoadScene("MensajeBien");
    }
    public int getNivelReto(){
        return nR;
    }

    // Update is called once per frame
    void Update()
    {
        if(problema>=5)
        {
            SceneManager.LoadScene("MensajeBien");
            nR=1;
            save.saveNL(nR);
        }
        
    }
}
