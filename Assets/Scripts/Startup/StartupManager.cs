using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupManager : MonoBehaviour
{
    const float LOAD_MAIN_MENU_SCENE_DELAY = 3.0F;

    void Awake()
    {
        Debug.Log(">>>>>> Startup Scene loaded");
    }

    void Start()
    {
        Invoke("LoadMenuMainScene", LOAD_MAIN_MENU_SCENE_DELAY);
    }

    void LoadMenuMainScene()
    {
        SceneManager.LoadScene("MenuMain");
    }
}
