using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastLevel1 : MonoBehaviour
{
    // Buscar los grupos de sliders en la escena
    public GameObject grupo1 ;
    public GameObject grupo2 ;
    public GameObject[]objectsToInstantiate;
    public Transform pos;
    public GameObject imagenFrac;

    // Variables para almacenar el número de sliders con valor 1
    int numSlidersGrupo1 = 0;
    int numSlidersGrupo2 = 0;

    public void readSliders(){
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
        Debug.Log("Número de sliders con valor 1 en grupo 1: " + numSlidersGrupo1);
        Debug.Log("Número de sliders con valor 1 en grupo 2: " + numSlidersGrupo2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void randomPanel(){
        int n= Random.Range(0,19); 
        imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
        imagenFrac.transform.parent=pos.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
