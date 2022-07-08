using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSlider : MonoBehaviour
{
    int value;
    public int targetValue;
    public int errorMargin;
    
    public void UpdateValue(System.Single val){
        value = (int) (val * 100);
        print(value);
    }
}
