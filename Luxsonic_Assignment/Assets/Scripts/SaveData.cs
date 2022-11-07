using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : Controller
{
   
    // Create a field of this class for the file.
    string saveFile;
    Data data = new Data();

    void Awake()
    {
        // Update the field once the persistent path exists.
        saveFile = Application.persistentDataPath + "/data.json";
    }

    public void readFile()
    {
        // Does the file exist?
        if (File.Exists(saveFile))
        {
            // Read the entire file and save its contents.
            string fileContents = File.ReadAllText(saveFile);
            data = JsonUtility.FromJson<Data>(fileContents);

        }
    }

    public void writeFile()
    {
        // Write JSON to file
        string jsonString = JsonUtility.ToJson(data);

        File.WriteAllText(saveFile, jsonString);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
