using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Permite que una pressure plate sea activada al ser precionada por un objeto fisicamente y con esto abrir una puerta
public class PressurePlate : MonoBehaviour
{
    public Animator laPresur;
    public Animator laPuerta;

    //Al posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta abuerta
    private void OnTriggerEnter(Collider other)
    {
        //LLamado a las animaciones
        laPresur.Play("Pushpollo");
        laPuerta.Play("Openpollo");
    }

    //Al dejar de posicionarce un objeto con collider encima de la presur se activan las animaciones de la presur y de la puerta cerrada
    private void OnTriggerExit(Collider other)
    {   
        //LLamado a las animaciones
        laPresur.Play("Pushnopollo");
        laPuerta.Play("Closedpollo");
    }
}
