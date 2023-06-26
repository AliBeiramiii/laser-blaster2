using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void Settings ()
    {

    }

    public void DisplayScores ()
    {

    }

    public void QuitGame ()
    {
        Debog.Log("QUIT!");
        Application.Quit();
    }
}

