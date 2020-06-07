using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class AreaSpawnPoint : MonoBehaviour
{
    public int openingDirection;
    // 1 = need bottom door
    // 2 = need left door
    // 3 = need top door
    // 4 = need right door

    private AreaTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {

        templates = GameObject.FindGameObjectWithTag("Templates").GetComponent<AreaTemplates>();

        Invoke("AreaSpawn", 0.1f);

    }

    void AreaSpawn()
    {
        if(spawned == false)
        {
            if (openingDirection == 1)   //spawn Area with a BOTTOM door
            {
                rand = Random.Range(0, templates.bottomAreas.Length);
                Instantiate(templates.bottomAreas[rand], transform.position, templates.bottomAreas[rand].transform.rotation);
            }
            else if (openingDirection == 2)  //spawn Area with LEFT door
            {
                rand =Random.Range(0, templates.leftAreas.Length);
                Instantiate(templates.leftAreas[rand], transform.position, templates.leftAreas[rand].transform.rotation);
            }
            else if (openingDirection == 3)  //spawn Area with TOP door
            {
                rand = Random.Range(0, templates.topAreas.Length);
                Instantiate(templates.topAreas[rand], transform.position, templates.topAreas[rand].transform.rotation);
            }
            else if (openingDirection == 4)  //spawn Area with RIGHT door
            {
                rand = Random.Range(0, templates.rightAreas.Length);
                Instantiate(templates.rightAreas[rand], transform.position, templates.rightAreas[rand].transform.rotation);
            }
            spawned = true;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AreaSpace"))
        {
            Destroy(gameObject);
        }
    }



}
