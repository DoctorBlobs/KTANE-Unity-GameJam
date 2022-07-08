using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightArray : MonoBehaviour{
    public GameObject[] toggleArr;
    public bool[] toggBoolSol;
    public bool[] toggBool;
    public GameObject checkButton;
    public bool correct = true;
    public GameObject Panel1_T;

    void Start()
    {
        toggBool = new bool[16];
    }

    void Update()
    {

    }

    public void UpdateArray(){
        bool[] toggBoolSol = {false, false, true, true , false, true, true, true, false, true, false, false,true, true, false, false};

        for(int i = 0; i < toggleArr.Length; i++){
            toggBool[i] = toggleArr[i].GetComponent<Toggle>().isOn;
        }
        
        for (int b = 0; b < toggBool.Length; b++){
            if (toggBoolSol[b] != toggBool[b]){
                correct = false;
            }
            
        }

        if(correct == true){
            checkButton.SetActive(false);
            Panel1_T.SetActive(true);
        }
    }
}
