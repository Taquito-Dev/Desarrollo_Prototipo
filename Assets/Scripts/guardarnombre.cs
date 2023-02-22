using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guardarnombre : MonoBehaviour
{
    public InputField inputNombre;
    public InputField inputContrasena;
    
    string nombre;
    string contrasena;

   

    public string getName(){
        nombre=inputNombre.text;
        return nombre;
    }
    public string getContrasena(){
        contrasena=inputContrasena.text;
        return contrasena;
    }

    public void setNombre(string userN){
    
    }
}
