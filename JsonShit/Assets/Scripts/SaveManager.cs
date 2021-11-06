using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    Vector3 _playerPosition;

    void Start()
    {
        Save();
        Load();
    }

    void Update()
    {
        
    }

    void Save()
    {
        string path = "Assets/Saves/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(_playerPosition);
        //writer.Flush();
        writer.Close();
    }

    void Load()
    {
        string path = "Assets/Saves/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        //tempPos = reader.ReadLine();
        reader.Close();
    }
}
