using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {   if (tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
