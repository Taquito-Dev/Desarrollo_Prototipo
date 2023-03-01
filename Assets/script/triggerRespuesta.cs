using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class triggerRespuesta : MonoBehaviour
{
    public Text porc;
    public double Meta=3;
    public double porcentaje;
    public double percent;

    public GameObject bien;
    public GameObject mal;

    public GameObject robot;
    public Vector3 temp;
    public Image health;

    float test = 0f;






    //public fracSelection FracSelection;
    //lo comentado fue lo que intente pero no jalo

    private void OnTriggerEnter (Collider other){
        //FracSelection.pos.SetActive(false);
        switch (other.tag){
            case "1-2":
            porcentaje+=.5;
                temp = new Vector3(0, 100, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.25f, 0, 1f);
                Destroy(other.gameObject,0.5f);
            break;
            case "1-3":
            porcentaje+=.333;
                temp = new Vector3(0, 66, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.166f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "1-4":
            porcentaje+=.25;
                temp = new Vector3(0, 50, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "1-5":
            porcentaje+=.2;
                temp = new Vector3(0, 40, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.1f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "1-8":
            porcentaje+=.125;
                temp = new Vector3(0, 25, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.06f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "1-9":
            porcentaje+=.111;
                temp = new Vector3(0, 22, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.05f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "2-5":
            porcentaje+=.4;
                temp = new Vector3(0, 80, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.2f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "2-6":
            porcentaje+=.333;
                temp = new Vector3(0, 66, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.16f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "2-8":
            porcentaje+=.25;
                temp = new Vector3(0, 50, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "3-3":
            porcentaje+=1;
                temp = new Vector3(0, 200, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.5f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "3-8":
            porcentaje+=.375;
                temp = new Vector3(0, 75, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.187f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "3-12":
            porcentaje+=.25;
                temp = new Vector3(0, 50, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.125f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "4-5":
            porcentaje+=.8;
                temp = new Vector3(0, 160, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.4f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "4-6":
            porcentaje+=.666;
                temp = new Vector3(0, 133, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.33f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "4-7":
            porcentaje+=.57;
                temp = new Vector3(0, 114, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.285f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "6-6":
            porcentaje+=1;
                temp = new Vector3(0, 200, 0);
                robot.transform.position += temp;  
                health.fillAmount = Mathf.Clamp(test=test+0.5f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "6-8":
            porcentaje+=.75;
                temp = new Vector3(0, 150, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.375f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "7-4":
            porcentaje+=1.75;
                temp = new Vector3(0, 350, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.875f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "7-10":
            porcentaje+=.7;
                temp = new Vector3(0, 140, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.35f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
            case "10-8":
            porcentaje+=1.25;
                temp = new Vector3(0, 250, 0);
                robot.transform.position += temp;
                health.fillAmount = Mathf.Clamp(test = test + 0.625f, 0, 1f);
                Destroy(other.gameObject, 0.5f);
            break;
        }
    }



    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "")
        {

        }
    }
    void Start()
    {  
        RectTransform robot = GetComponent<RectTransform>();
        
    }
      
    public void Scene()
    {
        bien.SetActive(false);
        mal.SetActive(false);
        SceneManager.LoadScene("Reto");
    }

    // Update is called once per frame
    void Update()
    {
    if(porcentaje>Meta){
            porc.text="Te pasaste. Intentalo de nuevo";
            mal.SetActive(true);
            bien.SetActive(false);
            Invoke("Scene", 2.0f);
    }
    else if(porcentaje>=1.9){
        porc.text="Listo";
            bien.SetActive(true);
            mal.SetActive(false);
            Invoke("Scene", 2.0f);
    }
    else{
            percent=porcentaje*100/2;
            porc.text=percent.ToString()+"% Completo"; 
        }
    }
}
