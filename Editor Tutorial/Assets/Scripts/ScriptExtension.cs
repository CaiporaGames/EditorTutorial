using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptExtension : MonoBehaviour
{

    //[Header("Variables")]
    public float scaler;

    //[Space(15)]

    //[Tooltip("É para usar o scaler float ou o vectorScaler?")] 
    public bool isVector = false;
    public Vector3 vectorScaler = Vector3.one;

    //[Header("Text Area")]    
    //[Space(15)]
    //[Multiline(5)]
    public string title;

    public Color defaultColor = Color.white; 


    // Update is called once per frame
    void Update()
    {
        if (isVector)
        {
            gameObject.transform.localScale = vectorScaler;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(scaler, scaler, scaler);
        }

        GetComponent<Renderer>().material.color = defaultColor;

        transform.GetChild(0).GetComponent<TextMeshPro>().text = title;

    }
}
