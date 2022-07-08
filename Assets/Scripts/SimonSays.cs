using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSays : MonoBehaviour
{
    string volgorde = "00223131";
    public GameObject[] buttons = new GameObject[4];

    public void StartSimon(){
        StartCoroutine("LightUp");
    }

    IEnumerator LightUp(){
        yield return new WaitForSeconds(0.5f);
        foreach (char c in volgorde){
            ColorBlock cb = buttons[(int)c - 48].GetComponent<Button>().colors;
            cb.normalColor = new Color(0.75f, 0.75f, 0.75f, 1);
            buttons[(int)c - 48].GetComponent<Button>().colors = cb;
            yield return new WaitForSeconds(0.5f);
            cb.normalColor = new Color(1, 1, 1, 1);
            buttons[(int)c - 48].GetComponent<Button>().colors = cb;
            yield return new WaitForSeconds(1);
        }
    }
}
