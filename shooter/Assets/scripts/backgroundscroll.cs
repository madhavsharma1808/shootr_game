using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroll : MonoBehaviour
{

    [SerializeField] float backgrounspeed;
    Material mymaterial;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        mymaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0f, backgrounspeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        mymaterial.mainTextureOffset += offset*Time.deltaTime;
    }
}
