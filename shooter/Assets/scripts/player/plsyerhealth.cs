using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plsyerhealth : MonoBehaviour
{
   
    // Start is called before the first frame update
    [SerializeField] int playerhealth=10;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("WELCOME");
       if(playerhealth>0)
        {
            playerhealth--;
        }
        else if(playerhealth<=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GAME OVER");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
