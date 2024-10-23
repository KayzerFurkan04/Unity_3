using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class createlasercode : MonoBehaviour
{
    public float speed = 1f; // Hareket hýzý

    void Update()
    {
        // Her frame'de yukarý doðru hareket et
        transform.position += Vector3.up * speed * Time.deltaTime;

        if(transform.position.y > 4.25)
        {
            Destroy(gameObject);
        }
    }
}
