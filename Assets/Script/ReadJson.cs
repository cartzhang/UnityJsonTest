using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[RequireComponent(typeof(WriteJson))]
public class ReadJson : MonoBehaviour
{

    void  Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            WriteJson obj = this.GetComponent<WriteJson>();
            obj.SaveJson();
            
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            GameStatus status = LoadJson.LoadJsonFromFile();
            Debug.Log(status);
        }
    }


}
