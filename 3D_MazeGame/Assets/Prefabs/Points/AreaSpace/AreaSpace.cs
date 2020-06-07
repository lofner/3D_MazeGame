using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class AreaSpace : MonoBehaviour
{

    public bool HaveDoorTop = false;
    public bool HaveDoorRight = false;
    public bool HaveDoorBottom = false;
    public bool HaveDoorLeft = false;

    private bool spawned = false;

    private PointTemplates templates;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Templates").GetComponent<PointTemplates>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && spawned == false)
        {
            Invoke("spawnAreaSpawnPoints", 0.1f);
        }
    }

    void spawnAreaSpawnPoints()
    {
        if(HaveDoorTop == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 44);
            Instantiate(templates.SpawnPointDoorBottom, position, Quaternion.identity);
        }

        if (HaveDoorRight == true)
        {
            Vector3 position = new Vector3(transform.position.x + 44, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointDoorLeft, position, Quaternion.identity);
        }

        if (HaveDoorBottom == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 44);
            Instantiate(templates.SpawnPointDoorTop, position, Quaternion.identity);
        }

        if (HaveDoorLeft == true)
        {
            Vector3 position = new Vector3(transform.position.x - 44, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointDoorRight, position, Quaternion.identity);
        }

        spawned = true;
    }
}
