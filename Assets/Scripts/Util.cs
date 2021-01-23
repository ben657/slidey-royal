using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Layers
{
    Standable = 1 << 6
}

public static class Util
{
    public static bool IsLayerInMask(int layer, LayerMask mask)
    {
        return mask == (mask | (1 << layer));
    }
}
