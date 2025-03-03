using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Objeto tipo Interactable OpenDoor usado para abrir puertas, cambiando entre dos estados de animación al ser presionado
public class OpenDoor : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
