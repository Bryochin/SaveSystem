using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Writing_File : MonoBehaviour
{

    private SaveData saveData;

    // Start is called before the first frame update
    protected void SaveToFile()
    {
        string json = JsonUtility.ToJson(saveData);
        if (!File.Exists(Application.persistentDataPath + "/data.save"))
        {
            File.Create(Application.persistentDataPath + "/data.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/data.save", json);
    }

    protected void LoadFile()
    {
        string json = JsonUtility.ToJson(saveData);
        if (!File.Exists(Application.persistentDataPath + "/data.save"))
        {
            File.Create(Application.persistentDataPath + "/data.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/data.save", json);
    }

}
