using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudoku : MonoBehaviour
{
    public Inputfield[] sudoku = new Inputfield[6];

    public void Check() {
        bool done = true;
        foreach (Inputfield input in sudoku){
            if (!input.isDone){
                done = false;
            }
        }
        if (done){
            print("sudoku done!!");
        }
    }
}
