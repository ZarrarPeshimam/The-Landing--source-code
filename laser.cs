using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class laser : MonoBehaviour
{
    float errorx = 6.1414f;
    float errory = -6.96f;
    public float speed = 2f;
    GameObject player;
    Player_motion ps;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        transform.position = new Vector2(player.transform.position.x+ Random.Range(-5f, 10f) + errorx, player.transform.position.y + errory);
        ps = player.GetComponent<Player_motion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex !=1)
        {
            Destroy(gameObject);
        }
        transform.position = new Vector2(transform.position.x, transform.position.y-speed*Time.deltaTime);
        if (transform.position.y<player.transform.position.y-20.09)
        {
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            ps.h -= Random.Range(15, 30);
            Destroy(gameObject);
        }

    }


}
