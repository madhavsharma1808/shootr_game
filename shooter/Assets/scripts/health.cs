using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float healthpoints=100;

    public float Gethealthpoints()
    {
        return healthpoints;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   if(tag=="enemy")
        { 
            if(healthpoints>0)
            {
                healthpoints = healthpoints -20;
            }
            if (healthpoints <= 0)
            {
                Destroy(gameObject);
                Debug.Log("ERROR");
            }
            }



    }
}
