using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosScript : MonoBehaviour
{
    [SerializeField] float radius = 1;
    [SerializeField] Vector3 size = Vector3.one;

    [SerializeField] Vector3[] spawner;

    [SerializeField] Mesh mesh;

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, radius);

        //Gizmos.color = Color.red;
        //Gizmos.DrawCube(gameObject.transform.position, size);
        //Gizmos.color = Color.yellow;
        //Gizmos.DrawWireCube(gameObject.transform.position, size);

        /*for (int i = 0; i < spawner.Length; i++)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(spawner[i], radius);
            Gizmos.color = Color.white;
            Gizmos.DrawLine(spawner[i], spawner[(int)Mathf.Repeat((i + 1), spawner.Length)]);
        }*/


        //Gizmos.DrawMesh(mesh,transform.position, Quaternion.identity, size);


        //Gizmos.DrawIcon(gameObject.transform.position, "UnityIcon");
    }

    private void OnDrawGizmosSelected()//Melhor performace
    {
        
    }
}
