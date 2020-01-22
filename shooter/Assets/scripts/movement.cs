using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float increase = 10f;
    [SerializeField] float padding = 1f;
    [SerializeField] GameObject laserprefab;
    [SerializeField] float laservelocity;
    [SerializeField] float firingperiod;
    Coroutine currentcoroutine;
    float xmin, xmax, ymin, ymax;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraset();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        laserfire();
    }

    private void laserfire()
    {

        
        if(Input.GetButtonDown("Fire1"))
        {
           currentcoroutine= StartCoroutine(firecontinous());
            
        }

        if(Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(currentcoroutine);
        }
    }

    IEnumerator firecontinous()
    {

        while(true)
        {
            GameObject laser = Instantiate(laserprefab, transform.position, Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, laservelocity);
            yield return new WaitForSeconds(firingperiod);
            
        }
    }

    private void cameraset()
    {
        Camera gamecamera = Camera.main;
         xmin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x+padding;
         xmax = gamecamera.ViewportToWorldPoint(new Vector3(1,0,0)).x-padding;
         ymin = gamecamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y+padding;
         ymax = gamecamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y-padding;

    }

    private void move()
    {
        var delx = Input.GetAxis("Horizontal")*Time.deltaTime*increase;
        var nextposx = Mathf.Clamp(transform.position.x + delx,xmin,xmax);
        var dely = Input.GetAxis("Vertical")*Time.deltaTime*increase;
        var nextposy = Mathf.Clamp(transform.position.y + dely,ymin,ymax);
        transform.position = new Vector2(nextposx,nextposy);

    }
}
