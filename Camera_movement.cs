using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{
    public Transform target;
    Vector3 velocity=Vector3.zero;
    public Vector3 offset;

    [Range(0,1)]
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = target.position+offset; // variable
        transform.position = Vector3.SmoothDamp(transform.position, pos,ref velocity, time); // ref usually used for smoothdamp
    }
}
