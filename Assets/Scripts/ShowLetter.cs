using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    public Sudoku sudoku;
    public Inputfield text;
    public toggles toggles;
    public GameObject letter;

    private void Update() {
        if (toggles.isDone){
            letter.SetActive(true);
            this.enabled = false;
        }
    }
}
