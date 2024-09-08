using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;

    private string Answer = "0451";
    private bool answerBool = bool.Parse("0451"); 
    private string Input;

    public GameObject CodePanel;
    public GameObject Trigger;
    //private bool IsAtDoor = false; 

    // Update is called once per frame
    public void Number(int number)
    {
        Ans.text += number.ToString();
        
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            //Destroy(CodePanel);
            
            Ans.text = "Correct";
            Door.SetBool("Open", true );
            StartCoroutine("StopDoor");
             Destroy(Trigger);    

        }
        else
        {
            Ans.text = "Invalid";
        }  
    }

    public void Clear()
    {
        Ans.text = "";
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(2.30f);
        Door.SetBool("Open", false);
        Door.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CodePanel.SetActive(true);
        }

        if(Ans.text == Answer)
        {
            Destroy(Trigger);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CodePanel.SetActive(false);
        /*
        if(answerBool ==  true)
        {
           // Destroy(CodePanel);
            Debug.Log("Poes");
        }

        else
        {
           CodePanel.SetActive(false);
        }
        //IsAtDoor = false;
        */


    }
}
