using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStartButton : MonoBehaviour
{
    
    public void openGameScene()
    {
        SceneManager.LoadScene("Zimmer_mit_Sauelen");
    }
}
