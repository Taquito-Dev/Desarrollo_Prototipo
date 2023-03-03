using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fracSelection : MonoBehaviour
{
    public GameObject[]objectsToInstantiate;
    public int frac;
    public Transform pos;

     
    // Start is called before the first frame update
    void Start()
    {
        generate();
    }
    void generate(){
        
        
        Instantiate(objectsToInstantiate[0], new Vector3(-8f,1f,-.24f), pos.transform.rotation);
        for(int i=0; i<8;i++){
            frac=Random.Range(0,objectsToInstantiate.Length);
            Instantiate(objectsToInstantiate[frac], new Vector3(-7f+i*.9f,1f,-.24f), pos.transform.rotation);
        }
        Instantiate(objectsToInstantiate[0], new Vector3(1f,1f,-.24f), pos.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
