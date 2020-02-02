using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float healthpoints=100;
    [SerializeField] float timeafterexplosion=1f;
    [SerializeField] GameObject explosionmaterial;

    public float Gethealthpoints()
    {
        return healthpoints;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   if(tag=="enemy" && tag!="redlaser")
        { 
           
           
                Destroy(gameObject);
            var explosion = Instantiate(explosionmaterial, transform.position, Quaternion.identity);
            Destroy(explosion, timeafterexplosion);
            
            }

            

    }
}
