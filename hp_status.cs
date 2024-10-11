using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_statuc : MonoBehaviour
{
    public Text hp;
    Player_motion ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.FindWithTag("player").GetComponent<Player_motion>();
        hp.text = "Health: " + ps.h + "%";
    }

    // Update is called once per frame
    void Update()
    {
        if (ps.h > 0)
        {
            hp.text = "Health: " + ps.h + "%";
        }
        else
        {
            hp.text = "Health: " + 0 + "%";
        }
    }
}
