using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletClass : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] public float bldirection = 1;
    [SerializeField] public float blspeed = 20.0f;
    [SerializeField] public float bldamege = 20.0f;
    [SerializeField] public float blDistance;
    [SerializeField] protected Transform tf;
    // Start is called before the first frame update
    protected void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    private void Update()
    {
        
    }
    protected void OnTriggerEnter2D(Collider2D hitInfo)
    {
        BulletClass bullet =  hitInfo.GetComponentInChildren<BulletClass>();

        personagem alvo = hitInfo.GetComponentInChildren<personagem>();
  
        if (alvo != null)
        {
            alvo.TomarDano(1);

            Destroy(gameObject);
        }
        else if(bullet == null) Destroy(gameObject);
    }

     public void disparo()
    {
        rb.velocity = transform.right * blspeed;
    }
    public void downDisparo()
    {
        rb.velocity = transform.up * blspeed *-1;
    }

    public void distanceControl()
    {
        print(tf.position.x);
       
        if (tf.position.x > blDistance+1)
        { 
            Destroy(gameObject);
        }

        if (tf.position.x < blDistance - 1)
        {
            Destroy(gameObject);
        }
    }
    
}
