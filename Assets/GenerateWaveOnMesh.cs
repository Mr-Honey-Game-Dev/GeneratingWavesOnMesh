using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class GenerateWaveOnMesh : MonoBehaviour
{
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;
    private Mesh mesh;
    private Vector3[] vertices;
    private List<VertexPos> vertexPosList = new List<VertexPos>();
   
    [SerializeField] [Range(0, 8)] private int meshSubDivisions = 0;
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float waveLengthMult = 1f;
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private WaveType waveType;
    [SerializeField] [Range(1,500)] private float YRangeForTan=50f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshFilter = GetComponent<MeshFilter>();

        if (meshSubDivisions > 0)
        {
            DivideMesh(meshFilter.mesh);
            meshRenderer.ResetBounds();
        }

        mesh = meshFilter.mesh;

        vertices = mesh.vertices;
        for(int i=0;i<vertices.Length;i++)
        {
            vertexPosList.Add(new VertexPos
            {
                position = vertices[i],
                originalY = vertices[i].y,
                waveType = waveType
            }); ;
        }
    }

    void Update()
    {
        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] = vertexPosList[i].CalculateNewPosition(amplitude, waveLengthMult,speed,YRangeForTan);
        }        
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
    }
    void DivideMesh(Mesh mesh) 
    {
        for (int i = 0; i < meshSubDivisions; i++) 
        {
         MeshHelper.Subdivide(mesh);
        }
    
    }

   
}
