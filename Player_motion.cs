using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_motion : MonoBehaviour
{
    public float move_speed = 5;
    public float h_input;
    public int h = 100;
    void Start()
    {

    }

    void Update()
    {
        if (h <= 0)
        {
            SceneManager.LoadScene(3);
        }
        h_input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * h_input * move_speed * Time.deltaTime,Space.World);
    }
}
