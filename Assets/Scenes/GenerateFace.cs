using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFace : MonoBehaviour
{

    Mesh mesh;
    Vector3[] verts;
    int[] tris;
    Vector2[] uvs;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        verts = new Vector3[4];
        tris = new int[6];
        uvs = new Vector2[4];

        verts[0] = new Vector3(0,0,0);
        verts[1] = new Vector3(10,0,0);
        verts[2] = new Vector3(0, 10 ,0);
        verts[3] = new Vector3(10, 10, 0);

        mesh.vertices = verts;
        
        tris[0] = 0;
        tris[1] = 2;
        tris[2] = 1;

        tris[3] = 1;
        tris[4] = 2;
        tris[5] = 3;

        mesh.triangles = tris;

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(0, 1);
        uvs[3] = new Vector2(1, 1);

        mesh.uv = uvs;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
