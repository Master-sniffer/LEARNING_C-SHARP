using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButton : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // берем активную сцену 
    }

    public void LoadInsta()
    {
        Application.OpenURL("https://www.instagram.com/master_sniffer/");
    }
}
