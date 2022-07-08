using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleButton : MonoBehaviour
{
    public bool done = false;
    public bool targetvalue = false;
    public toggles toggles;

    void Start(){
        setValue(false);
    }

    public void setValue(bool enabled){
        if (targetvalue == enabled){
            done = true;
            toggles.check();
        }
    }

}
