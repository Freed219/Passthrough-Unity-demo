using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Actualizar texto en pantalla
public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateText(string promptMessage)
        {
            promptText.text = promptMessage;
        }
}
