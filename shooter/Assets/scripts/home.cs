using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public void backtohome()
    {
        SceneManager.LoadScene("title screen");
    }
}
