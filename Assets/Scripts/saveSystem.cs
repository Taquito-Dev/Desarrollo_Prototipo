using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class saveSystem : MonoBehaviour
{
    guardarnombre userscr;
    InitialData problemascr;
    string savePath; 
    saveData data;
    public void Awake(){
        userscr=FindObjectOfType<guardarnombre>();
        problemascr=FindObjectOfType<InitialData>(); 
        savePath=Application.persistentDataPath+"/save.dat"; 
        if(!File.Exists(savePath)){ 
            saveData newData= new saveData();
            newData.username="jugador"; 
            newData.problem="1/2";
            newData.contrasena="secret";
            saveGame(newData);
        }
        data=LoadGame();
    }
    void saveGame(saveData dataToSave){
        string JsonData=JsonUtility.ToJson(dataToSave); 
        File.WriteAllText(savePath, JsonData);
    }
    saveData LoadGame(){
        string loadedData=File.ReadAllText(savePath);
        saveData datatoReturn=JsonUtility.FromJson<saveData>(loadedData);
        return datatoReturn;        
    }
    public void saveGameButton(){
        string userN=userscr.getName();
        string contrasenaN=userscr.getContrasena();

        data.username=userN;
        data.contrasena=contrasenaN;
        saveGame(data);
    }
    public void loadGameButton(){
        string userN=data.username;
        string contrasenaN=data.contrasena; 
        userscr.setNombre(userN);
    }
    public class saveData{
            public string username;
            public string problem;
            public string contrasena;
    }
}
