using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        var managers = GetComponentsInChildren<IManager>();
        foreach(var manager in managers)
        {
            manager.Init();
        }

        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }
}
