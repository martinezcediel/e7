using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI textMessage;

    void Start()
    {
        textMessage.text = "Pulsa cualquiera de las cuatro flechas";        // Al empezar el juego muestra este mensaje
    }

    void Update()
    {
        
        ShowMessage(KeyCode.RightArrow, "derecha");
        ShowMessage(KeyCode.LeftArrow, "izquierda");
        ShowMessage(KeyCode.UpArrow, "arriba");
        ShowMessage(KeyCode.DownArrow, "abajo");
        ShowMessage(KeyCode.P, "pium");
        ShowMessage(KeyCode.O, "pam");
    }

    public void ShowMessage(KeyCode key, string message)                  
    {
        

        if (Input.GetKeyDown(key))                            
        {
            textMessage.text = message;
        }

      
       
    }
}
