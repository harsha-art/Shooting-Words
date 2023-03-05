using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public GameObject gamestart;
    public void startgame()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
    public void exit()
    {
        Application.Quit();
    }
}
