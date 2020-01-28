using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserdestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    // Start is called before the first frame update
  
}

