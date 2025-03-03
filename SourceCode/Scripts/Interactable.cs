using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Interfaz para objetos interactuables como puertas, botones, cajas, etc.
public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promptMessage;
    public void BaseInteract()
    {
        if(useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
