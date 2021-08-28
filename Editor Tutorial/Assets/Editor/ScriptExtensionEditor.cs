using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScriptExtension))]
public class ScriptExtensionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();//Two variables will be show one in the monobehaiviour script and other on the editor script
        //DrawDefaultInspector();//Mantem as variaveis do scriptExtension script visiveis no inspector.

        ScriptExtension extension = (ScriptExtension)target;//conseguimos acessar todas as variaveis publicas do monobehaviour

        GUILayout.Label("Variables");
        extension.scaler = EditorGUILayout.Slider("Slider", extension.scaler, 0f,10f);

        GUILayout.Space(15);
        extension.isVector = EditorGUILayout.Toggle(new GUIContent("Scaler", "É para usar o scaler float ou o vectorScaler ?"), false);

        extension.vectorScaler = EditorGUILayout.Vector3Field("Vector Scaler", extension.vectorScaler);
        GUILayout.Space(15);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Text Area");
        extension.title = GUILayout.TextArea(extension.title);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(15);
        extension.defaultColor = EditorGUILayout.ColorField("Default Color", extension.defaultColor);       

    }
}
