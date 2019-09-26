using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public Animator animator;

    /*private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel("Page"+1);
        }
    }
    */

    public void ChangeScene(string scenename)
   {
       SceneManager.LoadScene(scenename);
   }

    public void FadeToLevel(string scenename)
    {
        animator.SetTrigger("ButtonClicked");
    }
}
