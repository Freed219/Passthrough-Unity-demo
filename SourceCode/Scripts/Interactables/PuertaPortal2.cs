using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaPortal2 : MonoBehaviour
{
    public Animator presur2;
    public Animator puertaPortal;

    void Start()
    {
        presur2.SetBool("Push",false);
        puertaPortal.SetBool("Dos",false);
    }

     //Al posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta abuerta
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Estatua")){
            presur2.SetBool("Push",true);
            puertaPortal.SetBool("Dos",true);
        }
        
    }

    //Al dejar de posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta cerrada
    private void OnTriggerExit(Collider other)
    {   
        if (other.GetComponent<Collider>().CompareTag("Estatua")){
            presur2.SetBool("Push",false);
            puertaPortal.SetBool("Dos",false);
        }
    }
}
