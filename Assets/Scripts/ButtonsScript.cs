using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitButton()
    {
        Application.Quit();
    }
    public void ToMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
