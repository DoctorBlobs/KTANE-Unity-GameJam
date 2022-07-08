using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class STOP : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void StartWait(){
        StartCoroutine("Wait");
    }
    IEnumerator Wait(){
        Vector3 mousepos = Input.mousePosition;
        yield return new WaitForSeconds(15);
        if (Input.mousePosition == mousepos){
            text.SetText("XXVII");
        }
    }
}
