using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    [SerializeField]waveconfig waved;
    List<Transform> enemy;

    [SerializeField] float wavespeed = 1f;
    int index = 0;
    void Start()
    {
        enemy = waved.Getwave();
        wavespeed = wavespeed * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void Update()
    {
        waveform();

    }

    private void waveform()
    {
        float enemypositionx = transform.position.x;
        float enemypositiony = transform.position.y;
        Vector2 enemyposition = new Vector2(enemypositionx, enemypositiony);
        float currentphasex = enemy[index].transform.position.x;
        float currentphasey = enemy[index].transform.position.y;
        Vector2 currentphase = new Vector2(currentphasex, currentphasey);

        if (enemypositionx == currentphasex && enemypositiony == currentphasey)
        {
            index++;
            if (index < 2)
            {

                Debug.Log(index);
            }
            Debug.Log(index);
            if (index == 3)
            {
                Destroy(gameObject);
            }
        }


        else
        {
            transform.position = Vector2.MoveTowards(enemyposition, currentphase, wavespeed);
        }
    }
}