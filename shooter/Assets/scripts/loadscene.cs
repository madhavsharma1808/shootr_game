﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    // Start is called before the first frame update
   public void nextscene()
    {
        SceneManager.LoadScene("core game");
    }
}
