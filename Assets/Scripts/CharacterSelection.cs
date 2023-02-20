using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        //Llenamos el array con los modelos
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        //Apagamos el renderer para no ver los modelos
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        //Activamos el modelo del personaje seleccionado
        if(characterList[index]){ characterList[index].SetActive(true);
        } 
    }

    //Función para el Botón Izquierdo
    public void ToggleLeft()
    {
        //Apagar el modelo actual
        characterList[index].SetActive(false);

        index--;
        if(index < 0) index = characterList.Length -1;
    
        //Prender el nuevo modelo
        characterList[index].SetActive(true);
    }

    //Función para el Botón Derecho
    public void ToggleRight()
    {
        //Apagar el modelo actual
        characterList[index].SetActive(false);

        index++;
        if(index == characterList.Length) index = 0;
    
        //Prender el nuevo modelo
        characterList[index].SetActive(true);
    }

    public void Guardar(){
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("GameScene");
    }
}
