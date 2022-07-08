using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] wires;
    public GameObject[] colouredButtons;
    public GameObject[] romanNumerals;
    private bool[] WiresCut = new bool[] {false, false, false, false };
    private string _colorResult = "";
    private int _romanNumeralsResult;
    private bool checkresult;
    private bool checkwireresults;
    private bool _romanNumeralsCheck;
    public GameObject colorAnswer;
    public GameObject wireAnswer;
    public GameObject romanAnswer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WirePuzzle();
        ColouredButtonsPuzzle();
        RomanNumeralsPuzzle();
    }

    public void OnWireClicked(int wireIndex)
    {
        wires[wireIndex].SetActive(false);
        WiresCut[wireIndex] = true;
    }

    public void ColorButtonClicked(string colorIndex)
    {
        _colorResult += colorIndex;
    }

    public void OnRomanClicked(int RomanNumeral)
    {
        _romanNumeralsResult += RomanNumeral;
    }

    void WirePuzzle()
    {
        if (WiresCut[0] && WiresCut[1] && WiresCut[3] && WiresCut[2] == false && checkwireresults == false)
        {
            checkwireresults = true;
            wireAnswer.SetActive(true);
            DeleteArray(wires);
        }
    }

    void ColouredButtonsPuzzle()
    {
        if (_colorResult == "00223131" && checkresult == false)
        {
            colorAnswer.SetActive(true);
            DeleteArray(colouredButtons);
            checkresult = true;
        }
    }

    void RomanNumeralsPuzzle()
    {
        if (_romanNumeralsResult == 27 && _romanNumeralsCheck == false)
        {
            romanAnswer.SetActive(true);
            DeleteArray(romanNumerals);
            _romanNumeralsCheck = true;
        }
    }

    void DeleteArray(GameObject[] gameobjectsarray)
    {
        for (int i = 0; i < gameobjectsarray.Length; i++)
        {
            gameobjectsarray[i].SetActive(false);
        }
    }
}
