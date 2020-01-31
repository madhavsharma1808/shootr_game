using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyplayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);
        SceneManager.LoadScene("GAME OVER");

    }
}
