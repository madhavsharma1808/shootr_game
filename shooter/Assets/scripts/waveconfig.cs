using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "wave config")]
public class waveconfig : ScriptableObject
{
   
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject wave;
    [SerializeField] float timebspawns;
    [SerializeField] float random;
    [SerializeField] int numberofenemies;
    [SerializeField] float speed;

    public GameObject Getenemy()
    {
        return enemy;
    }


    public List<Transform> Getwave()   
    {
        List<Transform> wavenew = new List<Transform>();
        foreach(Transform child in wave.transform)
        {
            wavenew.Add(child);
        }

        return wavenew;

    }


    public float Getrandom()
    {
        return random;
    }

    public float Gettimebspawns()
    {
        return timebspawns;
    }

    public int Getenemynumber()
    {
        return numberofenemies;
    }

    public float Getspeed()
    {
        return speed;
    }
}
