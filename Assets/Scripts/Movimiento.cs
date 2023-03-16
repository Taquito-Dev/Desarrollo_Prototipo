using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   private PlayerController player;
    private Animator anim;
    private float velocidad = 5f;
    private float inputHorizontal;
    private float rotacionPersonaje;
    private string direccion = "Derecha";
    private CharacterController controladorPersonaje;
    private Vector3 movimiento;
   
    void Start()
    {
        anim = this.GetComponent<Animator>();
        controladorPersonaje = this.GetComponent<CharacterController>();
        Application.targetFrameRate = 60;

    }

    void Update()
    {
        MoverPersonaje();
    }

    void MoverPersonaje()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        movimiento.z = inputHorizontal * velocidad;
        if(inputHorizontal > 0)
        {
            if(direccion == "Izquierda")
            {
                rotacionPersonaje = -180;
                this.transform.Rotate(Vector3.up,rotacionPersonaje);
                direccion = "Derecha";
            }
            anim.SetBool(name:"Caminando",value:true);
            controladorPersonaje.SimpleMove(movimiento);
            return;
        }

        if(inputHorizontal < 0)
        {
            if(direccion == "Derecha")
            {
                rotacionPersonaje = 180;
                this.transform.Rotate(Vector3.up,rotacionPersonaje);
                direccion = "Izquierda";
            }
            anim.SetBool(name:"Caminando",value:true);
            controladorPersonaje.SimpleMove(movimiento);
            return;
        }
        anim.SetBool(name:"Caminando",value:false);
    }
}
