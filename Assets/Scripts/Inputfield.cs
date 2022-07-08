using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inputfield : MonoBehaviour
{
    public string RequiredInput;
    public GameObject input;
    public bool isDone = false;
    public Sudoku sudoku;

    public void checkInput(){
        if (RequiredInput == input.GetComponent<TMP_InputField>().text){
            print("win!!!");
            isDone = true;
            Win();
        }
    }

    void Win(){
        sudoku.Check();
    }
}
