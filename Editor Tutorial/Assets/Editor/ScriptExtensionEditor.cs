using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScriptExtension))]
public class ScriptExtensionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        DrawDefaultInspector();//Mantem as variaveis do scriptExtension script visiveis no inspector.
    }
}
