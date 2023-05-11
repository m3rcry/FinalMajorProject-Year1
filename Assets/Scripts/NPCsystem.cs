using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCsystem : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public float wordSpeed;
    public bool playerIsClose;

    void update();
    {
        if(input.GetKeyDown(KeyCode.E) && playerIsClose);
        {
            if (dialoguePanel.activeInHierarchy)
            {

            }
        }   else
            {
                dialoguePanel.SetActive(true);
            }
    }
    
    public void zeroText()
    {
        dialogueText = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other);
    {
        if(other.CompareTag("player"));
        {
            playerIsClose = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other);
    {
        if(other.CompareTag("player"));
        {
            playerIsClose = false;
        }
    }
}
//(^._.^)