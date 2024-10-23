using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class script : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (GetComponent<Rigidbody>().transform.position.z < 4 && GetComponent<Rigidbody>().transform.position.z > -4)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
        }
        else
        {
            if(GetComponent<Rigidbody>().transform.position.z > 4)
            {
                GetComponent<Rigidbody>().transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, GetComponent<Rigidbody>().transform.position.y, 3.99f);
            }
            if (GetComponent<Rigidbody>().transform.position.z < -4)
            {
                GetComponent<Rigidbody>().transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, GetComponent<Rigidbody>().transform.position.y, -3.99f);
            }
        }
    }
}
