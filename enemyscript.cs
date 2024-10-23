using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject enemyprefab;
    public GameObject player;
    public float beklemesuresi = 0;

    public int playerhealth = 3;

    void Start()
    {

    }

    void Update()
    {
        bekle();

        if (beklemesuresi > 2f)
        {
            enemy();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player" && playerhealth >= 2)
        {
            Destroy(enemyprefab);
            playerhealth += -1;
        }

        if (other.tag == "player" && playerhealth < 2)
        {
            Destroy(enemyprefab);
            Destroy(player);
            playerhealth += -1;
        }

        if (other.tag == "laser")
        {
            Destroy(other.gameObject);
            Destroy(enemyprefab);
        }
    }

    void enemy()
    {
        float rastgelesoldansaga = Random.Range(-4, 4);
        Instantiate(enemyprefab, new Vector3(0, 4.8f, rastgelesoldansaga), Quaternion.identity);
        beklemesuresi = 0;
    }

    void bekle()
    {
        beklemesuresi += Time.deltaTime;
    }
}
