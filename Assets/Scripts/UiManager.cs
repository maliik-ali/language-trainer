using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public string UIScene;
    public string ImageTargetScene;
    public string ModelTargetScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadUiScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UIScene);
    }

    public void LoadImageScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(ImageTargetScene);
    }

    public void LoadModelScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(ModelTargetScene);
    }
}
