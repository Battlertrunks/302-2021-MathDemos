using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBetweenTwoPoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float percent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = AnimMath.Lerp(pointA.position, pointB.position, percent);
    }
}
