using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTowards : MonoBehaviour {
    
    public Transform target;

    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        // This slides the position towards the target:
        transform.position = AnimMath.Slide(transform.position, target.position, .01f);

        // Ease camera rotation to look at the target

        // Get vector to target
        Vector3 VectorToTarget = target.position - cam.transform.position;

        // Creates the desired rotation
        Quaternion targetRotation = Quaternion.LookRotation(VectorToTarget, Vector3.up);

        // Set camera to ease towards the target rotation
        cam.transform.rotation = AnimMath.Slide(cam.transform.rotation, targetRotation, .05f);

    }
}
