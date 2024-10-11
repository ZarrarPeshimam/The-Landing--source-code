using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platfrom_movement : MonoBehaviour
{
    public Transform A, B;
    Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {
        targetpos = A.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
