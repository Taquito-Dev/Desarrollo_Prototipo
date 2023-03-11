using UnityEngine;

public class Temporal : MonoBehaviour
{
    public GameObject[] objects; // array de objetos disponibles
    public string selectedObjectName; // nombre del objeto seleccionado

    void Start()
    {
        // obtener el nombre del objeto seleccionado del almacenamiento persistente
        selectedObjectName = PlayerPrefs.GetString("SelectedObject");

        // buscar el objeto seleccionado en el array de objetos disponibles
        foreach (GameObject obj in objects)
        {
            if (obj.name == selectedObjectName)
            {
                // mostrar el objeto seleccionado en la escena
                obj.SetActive(true);
                break;
            }
        }
    }
}
