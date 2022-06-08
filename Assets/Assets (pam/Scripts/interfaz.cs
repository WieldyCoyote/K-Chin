using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;

public class interfaz : MonoBehaviour
{
    //public GameObject spriteChange;
    public GameObject[] canvasArray;
    public NPCConversation Tutorial;
    public GameObject prevButton, nextButton, clientButton, pedido, slider;
    private int canvasIndex = 0;
    public bool tutorial1 = true, tuto2 = true, tuto3 = true, tuto4 = true, tuto5 = true;
    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(Tutorial);
        canvasArray[0].SetActive(true);
        canvasArray[1].SetActive(false);
        canvasArray[2].SetActive(false);
        canvasArray[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (canvasIndex) 
        { 
            case 0:
                clientButton.SetActive(false);
                pedido.SetActive(false);
                prevButton.SetActive(false);
                if (tutorial1) { nextButton.SetActive(false); } else { nextButton.SetActive(true); }
                
                break;
                
            case 1:
                clientButton.SetActive(true);
                if (tuto2) { pedido.SetActive(false); } else { pedido.SetActive(true); }
                prevButton.SetActive(true);
                if (tuto3) { nextButton.SetActive(false); } else { nextButton.SetActive(true); }
                
                break;
           
            case 2:
                clientButton.SetActive(true);
                pedido.SetActive(false);
                prevButton.SetActive(true);
                if (tuto4) { nextButton.SetActive(false); } else { nextButton.SetActive(true); }
                break;

            case 3:
                clientButton.SetActive(true);
                pedido.SetActive(false);
                prevButton.SetActive(true);
                nextButton.SetActive(false);
                if (tuto5) { slider.SetActive(false); } else { slider.SetActive(true); }
                break;
        }
    }

    public void finishStep1Tutorial() 
    { 
        tutorial1 = false;
    }

    public void finishStep2Tutorial()
    {
        tuto2 = false;
    }

    public void finishStep3Tutorial()
    {
        tuto3 = false;
    }

    public void finishStep4Tutorial()
    {
        tuto4 = false;
    }

    public void finishStep5Tutorial()
    {
        tuto5 = false;
    }

    public void SaltarTutorial() 
    {
        ConversationManager.Instance.SetBool("tutorial", true);
        ConversationManager.Instance.EndConversation();
        tutorial1 = false;
        tuto2 = false;
        tuto3 = false;
        tuto4 = false;
        tuto5 = false;
    }

    public void nextCanvas()
    {
        canvasArray[canvasIndex].SetActive(false);
        canvasIndex++;
        canvasIndex = canvasIndex % canvasArray.Length;
        canvasArray[canvasIndex].SetActive(true);
        
    }

    public void previousCanvas()
    {
        canvasArray[canvasIndex].SetActive(false);
        canvasIndex--;
        if (canvasIndex < 0) { canvasIndex = canvasArray.Length -1; }
        canvasIndex = canvasIndex % canvasArray.Length;
        canvasArray[canvasIndex].SetActive(true);

    }

    public void clientCanvas() 
    {
        canvasArray[canvasIndex].SetActive(false);
        canvasIndex = 0;
        canvasArray[canvasIndex].SetActive(true);
    }

    public class NPC : MonoBehaviour
    {
        public GameObject cliente;
        public NPCConversation Conversation;
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {

                cliente.SetActive(true);
                ConversationManager.Instance.StartConversation(Conversation);
            }
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}