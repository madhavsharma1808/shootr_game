using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadinstruction : MonoBehaviour
{
    // Start is called before the first frame update
   public void loadinst()
    {
        SceneManager.LoadScene("instructions");
    }
}
