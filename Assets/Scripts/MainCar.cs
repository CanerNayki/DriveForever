using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    
    public float dikey_h�z, yatay_h�z, varsay�lan_h�z;
    private float dikey_hareket,yatay_hareket;
    private float right_limit, left_limit;
    Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatay_hareket*50*yatay_h�z*Time.deltaTime,varsay�lan_h�z + dikey_hareket*50*dikey_h�z*Time.deltaTime);

        if (transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;
        } //sa� s�n�rr kontrol
        if (transform.position.x < -1.8f)
        {
            Vector3 left_limit = new Vector3(-1.80f , transform.position.y);
            transform.position = left_limit;    
        } //sol s�n�r kontrol
    }
    
}
