using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//using DialogueEditor;

public class introCutscene : MonoBehaviour
{
    /*public GameObject cliente;
    public GameObject design;
    public GameObject plancha;
    public GameObject doblado;*/
    public GameObject[] canvasArray;
    //private int activeCanvas = 0;
    private int canvasIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        /*cliente.SetActive(true);
        design.SetActive(false);
        plancha.SetActive(false);
        doblado.SetActive(false);*/



        canvasArray[0].SetActive(true);
        canvasArray[1].SetActive(false);
        canvasArray[2].SetActive(false);
        canvasArray[3].SetActive(false);
        canvasArray[4].SetActive(false);
        canvasArray[5].SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
               

    }


    public void nextCanvas()
    {   
        if(canvasIndex==5){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }else{
        canvasArray[canvasIndex].SetActive(false);
        canvasIndex++;
        canvasIndex = canvasIndex % canvasArray.Length;
        canvasArray[canvasIndex].SetActive(true);
        }
    }

    public void previousCanvas()
    {
        canvasArray[canvasIndex].SetActive(false);
        canvasIndex--;
        if (canvasIndex < 0) { canvasIndex = canvasArray.Length -1; }
        canvasIndex = canvasIndex % canvasArray.Length;
        canvasArray[canvasIndex].SetActive(true);

    }

    
    /*public void nextCanvas(int activeCanvas)
    {
        switch (activeCanvas)
        {
            case 0:

                ConversationManager.Instance.StartConversation(myConversation);
                break;

            case 1:
                design.SetActive(false);
                plancha.SetActive(true);
                activeCanvas = 2;
                Debug.Log("plancha");
                break;

            case 2:
                plancha.SetActive(false);
                doblado.SetActive(true);
                activeCanvas = 3;
                Debug.Log("doblado");
                break;

            case 3:
                doblado.SetActive(false);
                cliente.SetActive(true);
                activeCanvas = 0;
                Debug.Log("cliente");
                break;
            
            case 4:
                doblado.SetActive(false);
                cliente.SetActive(true);
                activeCanvas = 0;
                Debug.Log("cliente");
                break;
                  
            case 5:
                doblado.SetActive(false);
                cliente.SetActive(true);
                activeCanvas = 0;
                Debug.Log("cliente");
                break;
        }
    }


    /*public void previousCanvas(int activeCanvas)
    {
        switch (activeCanvas)
        {
            case 0:
                cliente.SetActive(false);
                doblado.SetActive(true);
                activeCanvas = 3;
                Debug.Log("doblado");
                break;

            case 1:
                design.SetActive(false);
                cliente.SetActive(true);
                activeCanvas = 0;
                Debug.Log("cliente");
                break;

            case 2:
                plancha.SetActive(false);
                design.SetActive(true);
                activeCanvas = 1;
                Debug.Log("design");
                break;

            case 3:
                doblado.SetActive(false);
                plancha.SetActive(true);
                activeCanvas = 2;
                Debug.Log("plancha");
                break;
        }
    }
    */

    /*public class NPC : MonoBehaviour
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
    }*/

}
