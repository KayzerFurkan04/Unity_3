using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserscript : MonoBehaviour
{
    public GameObject laserprefab;
    public GameObject player;
    public float beklemesuresi = 0;

    void Start()
    {

    }

    void Update()
    {
        bekle();

        if (beklemesuresi > 0.5f)
        {
            laser();
        }
    }

    void laser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserprefab, new Vector3(0, 0.2f, player.transform.position.z), Quaternion.identity);
            beklemesuresi = 0;
        }
    }

    void bekle()
    {
        beklemesuresi += Time.deltaTime;
    }
}
