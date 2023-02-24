using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class estalactite : BulletClass
{
    bool isFall = false;
    player pl;
    void Start()
    {
        pl = FindObjectOfType<player>();
        base.Start();
        rb.velocity = new Vector2 (0,0);
    }
    void Update()
    {
        if (pl.transform.position.y < tf.position.y && pl.transform.position.x <= tf.position.x +1 &&
           pl.transform.position.x >= tf.position.x - 1)
        {
            isFall = true;
            downDisparo();
        }else if (isFall == false){
            rb.velocity = new Vector2(0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (isFall == true) base.OnTriggerEnter2D(hitInfo);


    }
    } 
 