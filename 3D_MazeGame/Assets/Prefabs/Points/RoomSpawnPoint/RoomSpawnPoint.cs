using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawnPoint : MonoBehaviour
{
    public int openingDirection;
    // 1 = need DL
    // 2 = need D
    // 3 = need DR

    // 4 = need RU
    // 5 = need R
    // 6 = need RD

    // 7 = need UL
    // 8 = need U
    // 9 = need UR

    // 10 = need LU
    // 11 = need L
    // 12 = need LD


    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {

        templates = GameObject.FindGameObjectWithTag("Templates").GetComponent<RoomTemplates>();

        Invoke("RoomSpawning", 0.1f);

    }

    void RoomSpawning()
    {
        if (spawned == false)
        {
            //spawn room with D
            if (openingDirection == 1)   //DL
            {
                rand = Random.Range(0, templates.DL_rooms.Length);
                Instantiate(templates.DL_rooms[rand], transform.position, templates.DL_rooms[rand].transform.rotation);
            }

            if (openingDirection == 2)   //D
            {
                rand = Random.Range(0, templates.D_rooms.Length);
                Instantiate(templates.D_rooms[rand], transform.position, templates.D_rooms[rand].transform.rotation);
            }

            if (openingDirection == 3)   //DR
            {
                rand = Random.Range(0, templates.DR_rooms.Length);
                Instantiate(templates.DR_rooms[rand], transform.position, templates.DR_rooms[rand].transform.rotation);
            }

            //spawn room with R
            if (openingDirection == 4)   //RU
            {
                rand = Random.Range(0, templates.RU_rooms.Length);
                Instantiate(templates.RU_rooms[rand], transform.position, templates.RU_rooms[rand].transform.rotation);
            }

            if (openingDirection == 5)   //R
            {
                rand = Random.Range(0, templates.R_rooms.Length);
                Instantiate(templates.R_rooms[rand], transform.position, templates.R_rooms[rand].transform.rotation);
            }

            if (openingDirection == 6)   //RD
            {
                rand = Random.Range(0, templates.RD_rooms.Length);
                Instantiate(templates.RD_rooms[rand], transform.position, templates.RD_rooms[rand].transform.rotation);
            }

            //spawn room with U
            if (openingDirection == 7)   //UL
            {
                rand = Random.Range(0, templates.UL_rooms.Length);
                Instantiate(templates.UL_rooms[rand], transform.position, templates.UL_rooms[rand].transform.rotation);
            }

            if (openingDirection == 8)   //U
            {
                rand = Random.Range(0, templates.U_rooms.Length);
                Instantiate(templates.U_rooms[rand], transform.position, templates.U_rooms[rand].transform.rotation);
            }

            if (openingDirection == 9)   //UR
            {
                rand = Random.Range(0, templates.UR_rooms.Length);
                Instantiate(templates.UR_rooms[rand], transform.position, templates.UR_rooms[rand].transform.rotation);
            }

            //spawn room with L
            if (openingDirection == 10)   //LU
            {
                rand = Random.Range(0, templates.LU_rooms.Length);
                Instantiate(templates.LU_rooms[rand], transform.position, templates.LU_rooms[rand].transform.rotation);
            }

            if (openingDirection == 11)   //L
            {
                rand = Random.Range(0, templates.L_rooms.Length);
                Instantiate(templates.L_rooms[rand], transform.position, templates.L_rooms[rand].transform.rotation);
            }

            if (openingDirection == 12)   //LD
            {
                rand = Random.Range(0, templates.LD_rooms.Length);
                Instantiate(templates.LD_rooms[rand], transform.position, templates.LD_rooms[rand].transform.rotation);
            }

            spawned = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RoomSpace"))
        {
            Destroy(gameObject);
        }
    }



}
