using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class RoomSpace : MonoBehaviour
{
    //have door
    public bool UL = false;
    public bool U = false;
    public bool UR = false;

    public bool RU = false;
    public bool R = false;
    public bool RD = false;

    public bool DR = false;
    public bool D = false;
    public bool DL = false;

    public bool LU = false;
    public bool L = false;
    public bool LD = false;

    private bool spawned = false;

    private PointTemplates templates;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Templates").GetComponent<PointTemplates>();

        ScoresManager.instance.RoomsCounter += 1;   //count every time a room spawns
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && spawned == false)
        {
            Invoke("SpawnRoomSpawnPoints", 0.1f);
        }
    }

    void SpawnRoomSpawnPoints()
    {
        //have a door up
        if(DL == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 12.75f);
            Instantiate(templates.SpawnPointUL[0], position, Quaternion.identity);
        }

        if (D == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 12.75f);
            Instantiate(templates.SpawnPointU[0], position, Quaternion.identity);
        }

        if (DR == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 12.75f);
            Instantiate(templates.SpawnPointUR[0], position, Quaternion.identity);
        }
        //have a door right
        if (LU == true)
        {
            Vector3 position = new Vector3(transform.position.x + 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointRU[0], position, Quaternion.identity);
        }

        if (L == true)
        {
            Vector3 position = new Vector3(transform.position.x + 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointR[0], position, Quaternion.identity);
        }

        if (LD == true)
        {
            Vector3 position = new Vector3(transform.position.x + 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointRD[0], position, Quaternion.identity);
        }
        //have a door down
        if (UR == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 12.75f);
            Instantiate(templates.SpawnPointDR[0], position, Quaternion.identity);
        }

        if (U == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 12.75f);
            Instantiate(templates.SpawnPointD[0], position, Quaternion.identity);
        }

        if (UL == true)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 12.75f);
            Instantiate(templates.SpawnPointDL[0], position, Quaternion.identity);
        }
        //have a door left
        if (RD == true)
        {
            Vector3 position = new Vector3(transform.position.x - 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointLD[0], position, Quaternion.identity);
        }

        if (R == true)
        {
            Vector3 position = new Vector3(transform.position.x - 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointL[0], position, Quaternion.identity);
        }

        if (RU == true)
        {
            Vector3 position = new Vector3(transform.position.x - 12.75f, transform.position.y, transform.position.z);
            Instantiate(templates.SpawnPointLU[0], position, Quaternion.identity);
        }

        spawned = true;
    }
}
