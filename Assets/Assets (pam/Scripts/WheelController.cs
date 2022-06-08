using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelController : MonoBehaviour
{
    public GameObject interfaz, audioReloj, plancha, camiseta, camiseta2, next, reloj;
    GameObject[] btn;
    public List<Button> buttons;
    private float rotSpeed = 0;
    bool alreadyPlayed = false;
    public bool finishPlancha = false;
    public Image[] color;

    private AudioSource m_MyAudioSource;
    private Animator animator, animatorReloj;
    //bool m_Play;
    //bool m_ToggleChange = false;


    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.FindGameObjectsWithTag("buttonsPlancha");
        for (int i = 0; i < btn.Length; i++)
        {
            buttons.Add(btn[i].GetComponent<Button>());
        }
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].interactable = false;
        }
        camiseta.SetActive(false);
        camiseta2.SetActive(false);
        m_MyAudioSource = audioReloj.GetComponent<AudioSource>();
        animator = plancha.GetComponent<Animator>();
        animatorReloj = reloj.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((interfaz.GetComponent<interfaz>().canvasArray[2].activeInHierarchy == true) && (interfaz.GetComponent<spriteChange>().isFinished == true) && alreadyPlayed == false)
        {
            rotSpeed = 420f;
            transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
            m_MyAudioSource.Play();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].interactable = true;
            }
            camiseta.SetActive(true);
            animator.SetTrigger("cerrado");
            animatorReloj.SetTrigger("girando");
            
        }
        else { m_MyAudioSource.Stop(); }
        /*
        if (m_Play == true && m_ToggleChange == true)
        {
            m_MyAudioSource.Play();
            m_ToggleChange = false;
        }
        if (m_Play == false && m_ToggleChange == true)
        {
            m_MyAudioSource.Stop();
            m_ToggleChange = false;
        }*/
    }

    public void StartSpining() 
    {
        animator.SetTrigger("cerrado");
        animatorReloj.SetTrigger("girando");

    }

    public void StopSpining() 
    {
        Debug.Log(gameObject.transform.eulerAngles.z);
        if (gameObject.transform.eulerAngles.z > 248.767f || gameObject.transform.eulerAngles.z < 80.98f) 
        {
            for (int i = 0; i < color.Length; i++)
            {
                color[i].color = new Color32(50, 30, 7, 255);
            }

        }

        if (gameObject.transform.eulerAngles.z > 151.9014f && gameObject.transform.eulerAngles.z < 248.767f)
        {
            for (int i = 0; i < color.Length; i++)
            {
                color[i].color = new Color32(188, 124, 96, 255);
            }

        }


        if ((interfaz.GetComponent<spriteChange>().isFinished == true) && alreadyPlayed == false) 
        { 
            rotSpeed = 0f;
            transform.Rotate(0, 0, rotSpeed);
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].interactable = false;
            }
            //if () { btn[0].SetActive(true); }
            next.SetActive(true);
            camiseta2.SetActive(true);
            alreadyPlayed = true;
            m_MyAudioSource.Stop();
            finishPlancha = true;
        }
        //Debug.Log(rotSpeed);
    }
}
