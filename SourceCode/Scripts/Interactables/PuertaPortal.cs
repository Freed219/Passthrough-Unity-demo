using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaPortal : MonoBehaviour
{
    public Animator presur1;
    public Animator puertaPortal;

    void Start()
    {
        presur1.SetBool("Push",false);
        puertaPortal.SetBool("Uno",false);
    }

     //Al posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta abuerta
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Estatua")){
            presur1.SetBool("Push",true);
            puertaPortal.SetBool("Uno",true);
        }
        
    }

    //Al dejar de posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta cerrada
    private void OnTriggerExit(Collider other)
    {   
        if (other.GetComponent<Collider>().CompareTag("Estatua")){
            presur1.SetBool("Push",false);
            puertaPortal.SetBool("Uno",false);
        }
    }
}

