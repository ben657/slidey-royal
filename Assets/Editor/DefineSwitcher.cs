using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DefineSwitcher
{
    [MenuItem("Tools/SERVER")]
    private static void EnableServerMode()
    {
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, "SERVER");
    }

    [MenuItem("Tools/CLIENT")]
    private static void EnableClientMode()
    {
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, "");
    }
}
