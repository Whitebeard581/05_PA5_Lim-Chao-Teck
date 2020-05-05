using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene("GamePlay_Level1");
    }

    void Update()
    {
    }
}