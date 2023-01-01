using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Mesh_Test");

        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[3];
        Vector2[] uv = new Vector2[3];
        int[] triangles = new int[3];

        vertices[0] = new Vector3(0, 0, 100);
        vertices[1] = new Vector3(100, 100, 0);
        vertices[2] = new Vector3(0, 100, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(0, 1);
        uv[2] = new Vector2(1, 1);

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
        
        GetComponent<MeshFilter>().mesh = mesh;
    }
}
