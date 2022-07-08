using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SudokuInputfield : MonoBehaviour
{
    public string RequiredInput;
    public GameObject input;
    public bool isDone = false;
    public Sudoku Sudoku;

    public void checkInput(){
        if (RequiredInput == input.GetComponent<TMP_InputField>().text){
            print("win!!!");
            isDone = true;
            Win();
        }
    }

    void Win(){
        Sudoku.Check();
    }
}
