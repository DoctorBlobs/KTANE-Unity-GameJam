using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inputfield : MonoBehaviour
{
    public string RequiredInput;
    public GameObject input;
    public bool isDone = false;
    public string replace;

    public void checkInput(){
        if (RequiredInput.ToLower() == input.GetComponent<TMP_InputField>().text.ToLower()){
            print("win!!!");
            isDone = true;
            Win();
        }
    }

    void Win(){
        input.GetComponent<TMP_InputField>().text = replace;
        input.GetComponent<TMP_InputField>().readOnly = true;
    }
}
