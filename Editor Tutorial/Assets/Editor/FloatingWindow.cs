using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public class FloatingWindow : EditorWindow
{
    float scaler = 1;
    bool isVector = false;
    Vector3 vectorScaler = Vector3.one;
    string _title = "";
    Color defaultColor = Color.white;

    


    [MenuItem("Window/Floating Window")]
    public static void OpenWindow()
    {
         //GetWindow<FloatingWindow>("Floating Window");
         FloatingWindow window = GetWindow<FloatingWindow>("Floating Window");
         window.minSize = new Vector2(600,300);
         window.Show();
        EditorApplication.Beep();

    }

    private void OnGUI()//This will show owr fields on the window.
    {
        GUI.skin.label.fontSize = 24;       
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Floating Window");
        GUI.skin.label.fontSize = 12;
        GUI.skin.label.alignment = TextAnchor.UpperLeft;


        EditorGUILayout.LabelField("Variables", EditorStyles.boldLabel);
        EditorGUILayout.Space(15);
        scaler = EditorGUILayout.Slider("Slider", scaler, 0, 10);

        EditorGUILayout.Space(15);
        isVector = EditorGUILayout.Toggle(new GUIContent("Scaler", "É para usar o scaler float ou o vectorScaler ?"), isVector);

        vectorScaler = EditorGUILayout.Vector3Field("Vector Scaler", vectorScaler);
        EditorGUILayout.Space(15);

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Text Area", EditorStyles.boldLabel);
        _title = EditorGUILayout.TextArea( _title);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space(15);

        defaultColor = EditorGUILayout.ColorField("Default Color", defaultColor);

        Scaler();
        ChangeText();
        ColorChange();
    }

    void Scaler()
    {
        GameObject obj = (GameObject) Selection.activeObject;

        if (isVector)
        {
            obj.transform.localScale = vectorScaler;
        }
        else
        {
            obj.transform.localScale = new Vector3(scaler, scaler, scaler); 
        }        
    }

    void ChangeText()
    {
        GameObject obj = (GameObject)Selection.activeObject;
        if (obj.GetComponent<TextMeshPro>())
        {
            obj.GetComponent<TextMeshPro>().text = _title;
        }
    }

    void ColorChange()
    {
        GameObject obj = (GameObject)Selection.activeObject;
        if (obj.GetComponent<Renderer>())
        {
            obj.GetComponent<Renderer>().sharedMaterial.color = defaultColor;
        }
    }   
}
