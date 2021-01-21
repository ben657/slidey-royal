using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class GamemodeManager : SingletonNetworkedBehaviour<GamemodeManager>
{
    public GameObject playerPrefab;

    protected override void Awake()
    {
        if (IsServer)
        {
            var clients = NetworkManager.Instance.GetClientList();
            foreach(var client in clients)
            {
                GameObject player = Instantiate(playerPrefab);
                player.GetComponent<NetworkedObject>().SpawnAsPlayerObject
                    (
                        client.ClientId,
                        destroyWithScene: true
                    );
            }
        }
    }
}
