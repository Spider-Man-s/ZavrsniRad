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

        yield return new WaitForSeconds(1.5f);
        RemyCloud.SetActive(true);

        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "I don't know how anyone could sleep.";
        yield return new WaitForSeconds(3.5f);
        ElsaText.text = "The whole plane crashed down.";
        yield return new WaitForSeconds(3.5f);
        ElsaCloud.SetActive(false);
        CharlieCloud.SetActive(true);
        CharlieText.text = "I agree with Elsa, it was horrible.";
        yield return new WaitForSeconds(3.5f);
        CharlieCloud.SetActive(false);
    }



}
