using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBulletClass : BulletClass
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        disparo();
    }

    // Update is called once per frame
    void Update()
    {
        distanceControl();
    }
}
