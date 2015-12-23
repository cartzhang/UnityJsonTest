using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class GameStatus
{
    public string gameName;
    public string version;
    public bool isStereo;
    public bool isUseHardWare;
    public Refencenes[] statusList;
}

[Serializable]
public class Refencenes
{
    public Refencenes()
    {
        name = "";
        id = -1;
    }

    public string name;
    public int id;
}

