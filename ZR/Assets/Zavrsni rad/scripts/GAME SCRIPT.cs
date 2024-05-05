using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GAMESCRIPT : MonoBehaviour
{
    int scene = GlobalMemory.scenario;

    public GameObject RemyCloud;
    public TextMeshProUGUI RemyText;
    public GameObject CharlieCloud;
    public TextMeshProUGUI CharlieText;
    public GameObject ElsaCloud;
    public TextMeshProUGUI ElsaText;
    public void Begin()

    {
        StartCoroutine(Checkpoint1());
    }


    IEnumerator Checkpoint1()
    {

        yield return new WaitForSeconds(1.3f);
        RemyCloud.SetActive(true);

        yield return new WaitForSeconds(3f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "I don't know how anyone could sleep.";


    }



}
