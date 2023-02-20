using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class draganddrop : MonoBehaviour
{   
    Vector3 offset;



    void OnMouseDown(){
        offset=transform.position- MouseWorldPosition();
    }
    void OnMouseDrag(){
        transform.position=MouseWorldPosition()+offset;
    }

    Vector3 MouseWorldPosition(){
        var mouseScreenPos=Input.mousePosition;
        mouseScreenPos.z=Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }

   

}
