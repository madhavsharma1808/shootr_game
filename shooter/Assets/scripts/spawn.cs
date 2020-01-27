using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] List<waveconfig> waves;
    int startingwave=0;

    // Start is called before the first frame update
    void Start()
    {
       
        waveconfig waver = waves[startingwave];
        StartCoroutine(waveroute(waver));
    }

    IEnumerator waveroute(waveconfig waver)
    {
        for (int i = 0; i < waver.Getenemynumber(); i++)
        {   
            var newenemy=Instantiate(waver.Getenemy(), waver.Getwave()[0].transform.position, Quaternion.identity);
            newenemy.GetComponent<wave>().Setwavepath(waver);
            yield return new WaitForSeconds(waver.Gettimebspawns());
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
