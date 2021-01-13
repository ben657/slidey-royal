using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get { return instance; } }
    private static T instance = null;

    public bool persistent = true;

    protected virtual void Awake()
    {
        if(!instance)
        {
            instance = this as T;
            if (persistent) DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
