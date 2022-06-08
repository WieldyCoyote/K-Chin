using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamisetaFold : MonoBehaviour
{
    public GameObject sprites, frases, spriteFold, slider2, entregar, endGame, wheelController;
    public Sprite[] foldArray;
    public Image camiseta;
    //private int foldIndex;
    public Slider foldSlider, foldSlider2;
    bool alreadyInteracted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wheelController.GetComponent<WheelController>().finishPlancha == true && alreadyInteracted == false) 
        {
            foldSlider.interactable = true;
            alreadyInteracted = true;
        }
    }

    public void Fold()
    {
        camiseta.sprite = foldArray[(int)foldSlider.value];

        if (foldSlider.value == 0)
        {
            sprites.SetActive(true);
            frases.SetActive(true);
        }
        else
        {
            sprites.SetActive(false);
            frases.SetActive(false);
        }

        if(foldSlider.value == foldSlider.maxValue) 
        { 
            foldSlider.interactable = false;
            slider2.SetActive(true);
        }

            //Debug.Log((int)foldSlider.value);
    }

    public void Fold2()
    {
        camiseta.sprite = foldArray[(int)foldSlider2.value];
        
        if (foldSlider2.value < foldArray.Length - 1)
        {
            spriteFold.SetActive(false);
        }
        else
        {
            spriteFold.SetActive(true);
        }

        if (foldSlider2.value == foldSlider2.maxValue)
        {
            foldSlider2.interactable = false;
            entregar.SetActive(true);
        }

        //Debug.Log((int)foldSlider2.value);
    }

    public void Entregar() 
    {
        endGame.SetActive(true);
    }

}




