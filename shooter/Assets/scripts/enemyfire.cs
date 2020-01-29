using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire : MonoBehaviour
{

    health connect;
    [SerializeField] List<Sprite> breaking;
    public void Start()
    {
         connect = FindObjectOfType<health>();
    }
    private void Update()
    {
        changematerial();
    }
    
    void changematerial()
    {
        float fire = connect.Gethealthpoints();
        if ( fire >= 40 && fire<=60 )
        {
            GetComponent<SpriteRenderer>().sprite = breaking[0];
           
        }
        else if( fire>0 && fire<40 )
        {
            GetComponent<SpriteRenderer>().sprite = breaking[1];
            
        }
    }

}
