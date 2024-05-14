using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool yol_yapýldý = false;

     void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "mainCar" && yol_yapýldý == false)
        {
            Vector3  spawn_location = new Vector3 (transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            yol_yapýldý = true;
            ScoreManager.skor += 10;
            Destroy(this.gameObject,4f);
        }
       

    }
}
