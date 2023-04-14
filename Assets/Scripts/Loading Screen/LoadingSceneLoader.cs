
using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneLoader : MonoBehaviour
{
    [SerializeField] Image scrollBar;
    void Start()
    {
        StartCoroutine(LoadSceneAsync());   
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(LoadingData.dataToLoad);
        operation.allowSceneActivation = false;
        yield return null;
        while (operation.isDone == false)
        {
            scrollBar.fillAmount = operation.progress;

            if (operation.progress > 0.8f)
            {
                operation.allowSceneActivation = true;
            }

        }
    }

        public static void LoadScene(string scene)
        {
            LoadingData.dataToLoad = scene;
            SceneManager.LoadScene("LoadingScreen");
        }
    }
