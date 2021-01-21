using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Messaging;
using MLAPI.Connection;

public class NetworkManager : SingletonNetworkedBehaviour<NetworkManager>, IManager
{

    public void Init()
    {
#if SERVER
        Debug.Log("Initialising Network Manager as Server");
        NetworkingManager.Singleton.StartHost(createPlayerObject: false);
#else
        Debug.Log("Initialising Network Manager as Client");
        NetworkingManager.Singleton.StartClient();
#endif
    }

    public List<NetworkedClient> GetClientList()
    {
        if(IsServer)
            return NetworkingManager.Singleton.ConnectedClientsList;

        return null;
    }
}
