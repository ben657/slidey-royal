using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : SingletonBehaviour<MapManager>
{
    public Transform[] spawnPoints;

    public Vector3 GetSpawnPoint()
    {
        return spawnPoints[0].position;
    }
}
