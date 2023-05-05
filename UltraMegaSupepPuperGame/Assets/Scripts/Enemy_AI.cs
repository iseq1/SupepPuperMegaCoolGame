using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    public Transform dest1, dest2, dest3, dest4, dest5, player;
    public bool teleporting = true;
    public float teleportRate;
    public int randNum;
    
    void Start()
    {
        StartCoroutine(teleport());
    }

    void Update()
    {
        this.transform.LookAt(new Vector3(player.position.x, this.transform.position.y, player.position.z));
    }    
    
    IEnumerator teleport()
    {
        while (teleporting == true)
        {
            yield return new WaitForSeconds(teleportRate);
            randNum = Random.Range(0, 5);
            if (randNum == 0)
            {
                this.transform.position = dest1.position;
            }
            if (randNum == 1)
            {
                this.transform.position = dest2.position;
            }
            if (randNum == 2)
            {
                this.transform.position = dest3.position;
            }
            if (randNum == 3)
            {
                this.transform.position = dest4.position;
            }
            if (randNum == 4)
            {
                this.transform.position = dest5.position;
            }
            
        }
    }

}
