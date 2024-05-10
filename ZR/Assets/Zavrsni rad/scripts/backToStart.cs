using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Dreamteck.Splines;
using UnityEngine.SceneManagement;
using BNG;
public class backToStart : MonoBehaviour
{



    public void Start()
    {
        StartCoroutine(GoBackToStart());
    }
    ScreenFader sf;
    IEnumerator GoBackToStart()
    {

        yield return new WaitForSeconds(15f);
        if (sf == null)
        {
            sf = FindObjectOfType<ScreenFader>();
            if (sf != null)
            {
                sf.DoFadeIn();
            }
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }

}
