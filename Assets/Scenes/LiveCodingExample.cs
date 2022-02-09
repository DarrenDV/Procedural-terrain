using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveCodingExample : MonoBehaviour
{
    Mesh mesh;
    Vector3[] verts;

    public int xSize = 6, ySize = 3;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        int nVerts = (xSize+1) * (ySize+1);

        int counter = 0;
        for(int y = 0; y < ySize; y++)
        {
            for(int x = 0; x < xSize; x++)
            {
                verts[counter] = new Vector3(x, y, 0);
                counter++;
            }
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
