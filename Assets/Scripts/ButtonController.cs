
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CheckInput(TMP_InputField checkInputfield)
    {
        if (checkInputfield.text.ToLower() == "tim")
        {
            SceneManager.LoadScene("WinningScreen", LoadSceneMode.Single);
        }
    }
}
