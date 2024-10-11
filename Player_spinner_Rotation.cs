using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_spinner_Rotation : MonoBehaviour
{
    //public Transform player;
    public float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -rotationSpeed);
    }


}
