using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenControl : MonoBehaviour
{
    public GameObject loadScreenObj;
    public Slider slider;

    AsyncOperation async;

    public void LoadScreen(int LVL)
    {
        StartCoroutine(LoadingScreen(LVL));
    }

    IEnumerator LoadingScreen(int lvl)
    {
        loadScreenObj.SetActive(true);
        async = SceneManager.LoadSceneAsync(lvl);
        async.allowSceneActivation = false; 

        while (async.isDone == false)
        {
            slider.value = async.progress;

            if(async.progress == 0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
            }

            yield return true;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
