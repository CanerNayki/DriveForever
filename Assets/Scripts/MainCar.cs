using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    
    public float dikey_hýz, yatay_hýz, varsayýlan_hýz;
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
        rb.velocity = new Vector3(yatay_hareket*50*yatay_hýz*Time.deltaTime,varsayýlan_hýz + dikey_hareket*50*dikey_hýz*Time.deltaTime);

        if (transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;
        } //sað sýnýrr kontrol
        if (transform.position.x < -1.8f)
        {
            Vector3 left_limit = new Vector3(-1.80f , transform.position.y);
            transform.position = left_limit;    
        } //sol sýnýr kontrol
    }
    
}
