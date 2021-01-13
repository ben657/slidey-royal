using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class NetworkManager : SingletonBehaviour<NetworkManager>, IManager
{
    public static bool IsServer { get; private set; } = false;

    public void Init()
    {
#if SERVER
        Debug.Log("Initialising Network Manager as Server");
        NetworkingManager.Singleton.StartHost();
        IsServer = true;
#else
        Debug.Log("Initialising Network Manager as Client");
        NetworkingManager.Singleton.StartClient();
#endif
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
