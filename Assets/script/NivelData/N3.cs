using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3 : MonoBehaviour
{
    string valorNivel = "3";

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
