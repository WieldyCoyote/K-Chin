using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class spriteChange : MonoBehaviour
{
    private Color[] colorArray = { new Color32(255,255,255,255), new Color32(71,65,107,255), 
        new Color32(216,128,56,255), new Color32(78,40,46,255),  new Color32(255, 121, 248, 255), 
        new Color32(80, 80, 80, 255)};
    public Sprite[] spriteArray, spriteFoldArray;
    public string[] frasesArray;
    public List<Button> buttons;
    public Image[] color, sprites;
    public Image spritesFold;
    public TMP_Text[] frases;
    private int colorIndex = 0, spriteIndex = 0, fraseIndex = 0;
    public bool isFinished = false;

    private void Start() 
    {
        GameObject[] btn = GameObject.FindGameObjectsWithTag("buttonsDesign");
        for (int i = 0; i < btn.Length; i++)
        {
            buttons.Add(btn[i].GetComponent<Button>());
        }
    }

    public void Tutorial() 
    {
        colorIndex = 1;
        colorIndex = colorIndex % colorArray.Length;
        for (int i = 0; i < color.Length; i++)
        {
            color[i].color = colorArray[colorIndex];
        }

        spriteIndex = 12;
        spriteIndex = spriteIndex % spriteArray.Length;
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].sprite = spriteArray[spriteIndex];
        }
        spritesFold.sprite = spriteFoldArray[spriteIndex];

        fraseIndex = 4;
        fraseIndex = fraseIndex % frasesArray.Length;
        for (int i = 0; i < frases.Length; i++)
        {
            frases[i].text = frasesArray[fraseIndex];
        }
    }

    public void SelectNextColor()
    {
        colorIndex++;
        colorIndex = colorIndex % colorArray.Length;
        for (int i = 0; i < color.Length; i++)
        {
            color[i].color = colorArray[colorIndex];
        }

        //color.color = colorArray[colorIndex];
        /*if (colorIndex == 5) 
        {
            for (int i = 0; i < frases.Length; i++)
            {
                frases[i].color = colorArray[0];
            }
            //frases.color = colorArray[0]; 
        } else 
        {
            for (int i = 0; i < frases.Length; i++)
            {
                frases[i].color = new Color32(28, 22, 24, 255);
            }
            //frases.color = colorArray[5]; 
        }*/
        //Debug.Log("todo ok");
    }

    public void SelectPreviousColor()
    {

        colorIndex--;
        if (colorIndex < 0) { colorIndex = colorArray.Length - 1; }
        colorIndex = colorIndex % colorArray.Length;
        for (int i = 0; i < color.Length; i++)
        {
            color[i].color = colorArray[colorIndex];
        }
        //color.color = colorArray[colorIndex];
        /*if (colorIndex == colorArray.Length-1) 
        {
            for (int i = 0; i < frases.Length; i++)
            {
                frases[i].color = colorArray[0];
            }
        } else 
        {
            for (int i = 0; i < frases.Length; i++)
            {
                frases[i].color = new Color32(28, 22, 24, 255);
            }
        }*/
    }

    public void SelectNextSprite()
    {
        spriteIndex++;
        spriteIndex = spriteIndex % spriteArray.Length;
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].sprite = spriteArray[spriteIndex];
        }
        spritesFold.sprite = spriteFoldArray[spriteIndex];
        //sprites.sprite = spriteArray[spriteIndex];
        //Debug.Log("todo ok");
    }

    public void SelectPreviousSprite()
    {
        spriteIndex--;
        if (spriteIndex < 0) { spriteIndex = spriteArray.Length - 1; }
        spriteIndex = spriteIndex % spriteArray.Length;
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].sprite = spriteArray[spriteIndex];
        }
        spritesFold.sprite = spriteFoldArray[spriteIndex];
        //sprites.sprite = spriteArray[spriteIndex];

    }

    public void SelectNextFrase()
    {
        fraseIndex++;
        fraseIndex = fraseIndex % frasesArray.Length;
        for (int i = 0; i < frases.Length; i++)
        {
            frases[i].text = frasesArray[fraseIndex];
        }
        //frases.text = frasesArray[fraseIndex];
        //Debug.Log("todo ok");
    }

    public void SelectPreviousFrase()
    {
        fraseIndex--;
        if (fraseIndex < 0) { fraseIndex = frasesArray.Length - 1; }
        fraseIndex = fraseIndex % frasesArray.Length;
        for (int i = 0; i < frases.Length; i++)
        {
            frases[i].text = frasesArray[fraseIndex];
        }
        //frases.text = frasesArray[fraseIndex];

    }

    public void FinishDesign() 
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].interactable = false;
        }
        isFinished = true;
        Debug.Log(colorIndex + " " + spriteIndex + " " + fraseIndex);
    }
}
