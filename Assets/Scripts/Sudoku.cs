using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudoku : MonoBehaviour
{
    public SudokuInputfield[] sudoku = new SudokuInputfield[15];
    public GameObject Answer;
    public bool isDone;

    public void Check() {
        bool done = true;
        foreach (SudokuInputfield input in sudoku){
            if (!input.isDone){
                done = false;
            }
        }
        if (done){
            print("sudoku done!!");
            Answer.SetActive(true);
            isDone = true;
        }
    }
}
