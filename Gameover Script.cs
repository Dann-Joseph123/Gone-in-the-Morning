using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene"); //loads on the game
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("SCENE 1"); //loads on start menu
    }
}
