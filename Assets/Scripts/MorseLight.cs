using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorseLight : MonoBehaviour
{
    public bool running = false;
    public GameObject MorseOn;
    private string morseCode = "//-.-/---/.";

    public float shortOnTime;
    public float longOnTime;
    public float pauseOffTime;
    public float betweenOffTime;

    public bool compWait;

    public int i = 0;

    void Start()
    {
        running = false;
        compWait = true;
    }

    void Update()
    {
        if (running == true)
        {
            while (i < morseCode.Length && compWait == true)
            {
                compWait = false;
                char MorseC = morseCode[i];
                Debug.Log(MorseC);
                if (MorseC == '.')
                {
                    StartCoroutine(MorseTim(shortOnTime, true));
                }
                else if (MorseC == '-')
                {
                    StartCoroutine(MorseTim(longOnTime, true));
                }

                else if (MorseC == '/')
                {
                    StartCoroutine(MorseTim(betweenOffTime - pauseOffTime, false));
                }

                else
                {
                    Debug.LogError("Morse Error::Not a usable code");
                }

            }

        }
    }


    IEnumerator MorseTim(float timeWait, bool state){
        MorseOn.SetActive(state);
        yield return new WaitForSeconds(timeWait);
        MorseOn.SetActive(false);
        yield return new WaitForSeconds(pauseOffTime);
        compWait = true;
        i++;
    }

    public void StartMorse()
    {
        running = true;
    }
}
