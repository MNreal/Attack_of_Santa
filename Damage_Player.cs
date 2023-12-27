using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    //Get circle collider
    public Collider2D coll;
    //set health
    public float health = 100f;

    
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
        
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        while( coll ==true )
        {
            health -= 5f;
           
            break;
        }
           
    }

 
}
    
