using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResumeButton ()
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsButton ()
    {
        SceneManager.LoadScene(2);
    }

    public void ControlsButton ()
    {
        SceneManager.LoadScene(3);
    }

    public void ExitButton ()
    {
        Application.Quit();
    }
}
