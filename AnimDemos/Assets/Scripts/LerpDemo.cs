using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    //Properties
    public GameObject objectStart;
    public GameObject objectEnd;

    [Range(-1, 2)] public float percent = 0;


    public float animationLength = 2;
    private float animationPlayheadTime = 0;
    private bool isAnimPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isAnimPlaying)
        {
            // Move animPlayhead forward
            animationPlayheadTime += Time.deltaTime;
            // calc new value for percent
            percent = animationPlayheadTime / animationLength;
            // Clamp in 0 to 1 range
            percent = Mathf.Clamp(percent, 0, 1);
            // Move object to lerped position
            DoTheLerp();
            // Stop playing:
            if (percent >= 1) isAnimPlaying = false;
        }
        

    }

    private void DoTheLerp()
    {
        transform.position = AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent);
    }

    public void PlayTweenAnim()
    {
        isAnimPlaying = true;
        animationPlayheadTime = 0;
    }

    private void OnValidate()
    {
        DoTheLerp();
    }
}
