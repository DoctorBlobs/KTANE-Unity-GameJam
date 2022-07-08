using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggles : MonoBehaviour
{
    public toggleButton[] Toggles = new toggleButton[6];
    public bool isDone;

    public void check(){
        bool done = true;
        foreach (toggleButton toggle in Toggles){
            if (!toggle.done){
                done = false;
            }
        }
        
        if (done){
            print("aaAA");
            isDone = true;
        }
    }
}
