using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultButton : MonoBehaviour
{
    public bool hasBeenPressed = false;
    public string ButtonName = "EmptyButton";
    [SerializeField] bool isSwitch = false;

    public void Button(){
        hasBeenPressed = true;
        print("ButtonPressed!");
        if (isSwitch){ 
            //Change textures here
        }
    }
}
