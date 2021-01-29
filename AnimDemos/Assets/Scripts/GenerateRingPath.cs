using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class GenerateRingPath : MonoBehaviour
{
    [Range(10, 60)] public int num = 10;
    [Range(2, 20)] public float radius = 5;
    LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();

        // Generate a bunch of points!
        float dis = 2;
        float rad = 0;

        Vector3[] pts = new Vector3[num];

        for (int i = 0; i < num; i++)
        {
            pts[i] = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius + transform.position;
            rad += Mathf.PI * 2 / num; // Increase the angle
        }
        line.positionCount = num;
        line.SetPositions(pts);
    }

  
    void Update()
    {
        
    }
}
