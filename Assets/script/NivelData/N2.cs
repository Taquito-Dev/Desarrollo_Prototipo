using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2 : MonoBehaviour
{
    string valorNivel = "2";

    public string prefsNivel = "nivel";

    // Start is called before the first frame update
    void Start()
    {
        SaveNivel();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveNivel()
    {
        PlayerPrefs.SetString("prefsNivel", valorNivel);
    }
}
