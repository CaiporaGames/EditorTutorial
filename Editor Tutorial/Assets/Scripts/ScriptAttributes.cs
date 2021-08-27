using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAttributes : MonoBehaviour
{
    [Header("Variables")]  

    [Range(0f, 10f)][SerializeField] float scaler;

    [Space(15)]

    [Tooltip("É para usar o scaler float ou o vectorScaler?")][SerializeField] bool isVector = false;
    [SerializeField] Vector3 vectorScaler = Vector3.one;  

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
    }
}
