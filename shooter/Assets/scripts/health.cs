using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update

    int maxhealth = 20;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        maxhealth = maxhealth - 10;
        if(maxhealth<=0)
        {
            Destroy(gameObject);
        }
    }
}
