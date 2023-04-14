using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void load1()
    {
        SceneManager.LoadScene("Mission1");
    }
    public void load2()
    {
        SceneManager.LoadScene("Mission2");
    }
}
