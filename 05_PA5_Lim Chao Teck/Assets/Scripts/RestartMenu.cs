﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene("GameStart");
    }

    void Update()
    {
    }
}
