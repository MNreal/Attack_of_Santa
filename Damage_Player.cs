using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : MonoBehaviour
{
    //Get circle collider
    public Collider2D coll;
    //set health
    public int health = 100;

    public HealthBar healthBar;

    public AudioSource GameMusic;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
        GameMusic.Play();
        healthBar.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    
        
        if(health <= 0)
        {
            LevelManager.manager.GameOverSound();
            LevelManager.manager.GameOver();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        while( coll ==true )
        {
            health -= 5;
            healthBar.SetHealth(health);
            break;
        }
           
    }

 
}
    
