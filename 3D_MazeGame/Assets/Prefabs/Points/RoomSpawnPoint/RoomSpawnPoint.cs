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

    private RoomTemplates_phase_0 phase_0;
    private RoomTemplates_phase_1 phase_1;
    private RoomTemplates_phase_2 phase_2;

    private int rand;
    private bool spawned = false;

    void Start()
    {

        phase_0 = GameObject.FindGameObjectWithTag("Templates_phase").GetComponent<RoomTemplates_phase_0>();
        phase_1 = GameObject.FindGameObjectWithTag("Templates_phase").GetComponent<RoomTemplates_phase_1>();
        phase_2 = GameObject.FindGameObjectWithTag("Templates_phase").GetComponent<RoomTemplates_phase_2>();

        Invoke("RoomSpawning", 0.1f);

    }

    void RoomSpawning()
    {
        if (spawned == false)
        {
            //spawn room with D
            if (openingDirection == 1)   //DL
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.DL_rooms.Length);
                    Instantiate(phase_0.DL_rooms[rand], transform.position, phase_0.DL_rooms[rand].transform.rotation);
                }               
            }

            if (openingDirection == 2)   //D
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.D_rooms.Length);
                    Instantiate(phase_0.D_rooms[rand], transform.position, phase_0.D_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 3)   //DR
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.DR_rooms.Length);
                    Instantiate(phase_0.DR_rooms[rand], transform.position, phase_0.DR_rooms[rand].transform.rotation);
                }
            }

            //spawn room with R
            if (openingDirection == 4)   //RU
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.RU_rooms.Length);
                    Instantiate(phase_0.RU_rooms[rand], transform.position, phase_0.RU_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 5)   //R
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.R_rooms.Length);
                    Instantiate(phase_0.R_rooms[rand], transform.position, phase_0.R_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 6)   //RD
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.RD_rooms.Length);
                    Instantiate(phase_0.RD_rooms[rand], transform.position, phase_0.RD_rooms[rand].transform.rotation);
                }
            }

            //spawn room with U
            if (openingDirection == 7)   //UL
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.UL_rooms.Length);
                    Instantiate(phase_0.UL_rooms[rand], transform.position, phase_0.UL_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 8)   //U
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.U_rooms.Length);
                    Instantiate(phase_0.U_rooms[rand], transform.position, phase_0.U_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 9)   //UR
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.UR_rooms.Length);
                    Instantiate(phase_0.UR_rooms[rand], transform.position, phase_0.UR_rooms[rand].transform.rotation);
                }
            }

            //spawn room with L
            if (openingDirection == 10)   //LU
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.LU_rooms.Length);
                    Instantiate(phase_0.LU_rooms[rand], transform.position, phase_0.LU_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 11)   //L
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.L_rooms.Length);
                    Instantiate(phase_0.L_rooms[rand], transform.position, phase_0.L_rooms[rand].transform.rotation);
                }
            }

            if (openingDirection == 12)   //LD
            {
                if (ScoresManager.instance.RoomsTemplatesSelectionPhase == 0)
                {
                    rand = Random.Range(0, phase_0.LD_rooms.Length);
                    Instantiate(phase_0.LD_rooms[rand], transform.position, phase_0.LD_rooms[rand].transform.rotation);
                }
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
