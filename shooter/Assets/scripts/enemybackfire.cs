﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybackfire : MonoBehaviour
{
    [SerializeField] GameObject enemymissile;
    [SerializeField] float timebwlasers=0.8f;
    [SerializeField] float lvelocity=2f;
    waveconfig waveconfig;

    // Start is called before the first frame update
    void Start()
    {
        waveconfig = FindObjectOfType<waveconfig>();
        StartCoroutine(enemyfire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator enemyfire()
    {
        while (true)
        {

            var enemy = Instantiate(enemymissile, transform.position, Quaternion.identity);
            enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, lvelocity * Time.deltaTime);
            yield return new WaitForSeconds(timebwlasers);
        }
    }
}
