using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hover : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextoCubo;
    private Renderer renderer;


    void Start()
    {
        //TextoCubo = GetComponent<TextMeshProUGUI>();
        //TextoCubo.gameObject.SetActive(false);
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        switch (tag)
        {
            case "1-2":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-2";
                //TextoCubo.gameObject.SetActive(true);
                break;
            case "1-3":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-3";
                break;
            case "1-4":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-4";
                break;
            case "1-5":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-5";
                break;
            case "1-8":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-8";
                break;
            case "1-9":
                renderer.material.color = Color.red;
                TextoCubo.text = "1-9";
                break;
            case "2-5":
                renderer.material.color = Color.red;
                TextoCubo.text = "2-5";
                break;
            case "2-6":
                renderer.material.color = Color.red;
                TextoCubo.text = "2-6";
                break;
            case "2-8":
                renderer.material.color = Color.red;
                TextoCubo.text = "2-8";
                break;
            case "3-3":
                renderer.material.color = Color.red;
                TextoCubo.text = "3-3";
                break;
            case "3-8":
                renderer.material.color = Color.red;
                TextoCubo.text = "3-8";
                break;
            case "3-12":
                renderer.material.color = Color.red;
                TextoCubo.text = "3-12";
                break;
            case "4-5":
                renderer.material.color = Color.red;
                TextoCubo.text = "4-5";
                break;
            case "4-6":
                renderer.material.color = Color.red;
                TextoCubo.text = "4-6";
                break;
            case "4-7":
                renderer.material.color = Color.red;
                TextoCubo.text = "4-7";
                break;
            case "6-6":
                renderer.material.color = Color.red;
                TextoCubo.text = "6-6";
                break;
            case "6-8":
                renderer.material.color = Color.red;
                TextoCubo.text = "6-8";
                break;
            case "7-4":
                renderer.material.color = Color.red;
                TextoCubo.text = "7-4";
                break;
            case "7-10":
                renderer.material.color = Color.red;
                TextoCubo.text = "7-10";
                break;
            case "10-8":
                renderer.material.color = Color.red;
                TextoCubo.text = "10-8";
                break;
        }
    }

    void OnMouseExit()
    {
        switch (tag)
        {
            case "1-2":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                //TextoCubo.gameObject.SetActive(false);

                break;
            case "1-3":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "1-4":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "1-5":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "1-8":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "1-9":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "2-5":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "2-6":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "2-8":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "3-3":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "3-8":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "3-12":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "4-5":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "4-6":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "4-7":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "6-6":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "6-8":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "7-4":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "7-10":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
            case "10-8":
                renderer.material.color = Color.white;
                TextoCubo.text = "0";
                break;
        }
    }
}
