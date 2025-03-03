using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameData
{
    public int currentlevel;
    public Vector3 playerPosition;
    public GameData()
    {
        currentlevel = 1;
        playerPosition = new Vector3(483.38f, 10.09f, 383.55f);
    }
}
