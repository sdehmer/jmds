using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    
    public void openGameScene()
    {
        SceneManager.LoadScene("Zimmer_mit_Sauelen");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
