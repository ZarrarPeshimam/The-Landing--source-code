using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class q_script : MonoBehaviour
{
    float t =0;
    public GameObject q1,q2,q3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (q1.activeSelf)
        {
            if (t < 3)
            {
                t += Time.deltaTime;
            }
            else
            {
                t = 0;
                q1.SetActive(false);
                q2.SetActive(true);
            }
        }else if (q2.activeSelf)
        {
            if (t < 1.5)
            {
                t += Time.deltaTime;
            }
            else
            {
                q2.SetActive(false);
                q3.SetActive(true);
            }
        }
        else if (q3.activeSelf)
        {
            if (t < 4)
            {
                t += Time.deltaTime;
            }
            else
            {
                q3.SetActive(false);
            }
        }

    }
}
