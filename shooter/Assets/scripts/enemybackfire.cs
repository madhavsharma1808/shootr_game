using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybackfire : MonoBehaviour
{
    [SerializeField] Sprite enemymissile;
    [SerializeField] float timebwlasers=0.8f;
    waveconfig waveconfig;

    // Start is called before the first frame update
    void Start()
    {
        waveconfig = FindObjectOfType<waveconfig>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(enemyfire());
    }

    IEnumerator enemyfire()
    {
        float locationx = transform.position.x;
        float locationy = transform.position.y;
        Vector2 locationfinal = new Vector2(locationx, locationy);
        var newenemylaser = Instantiate(enemymissile, locationfinal, Quaternion.identity);
        yield return new WaitForSeconds(timebwlasers);
    }
}
