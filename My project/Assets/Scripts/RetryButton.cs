using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Transition()
    {
        if (Input.GetButton("Jump"))
        {
            SceneManager.LoadScene(0);
        }
        
    }

    public void onExit()
    {
        if (Input.GetButton("Cancel"))
        {
             Application.Quit();
        }

    }
    void Update()
    {
        Transition();
        onExit();
    }
    
}
