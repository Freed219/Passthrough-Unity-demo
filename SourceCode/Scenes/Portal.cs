using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Clase del portal el cual nos permite cambiar entre escenas 
public class Portal : MonoBehaviour
{
    public int sceneID;
    void OnTriggerEnter(Collider other)
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneID + 1);
    }
}
