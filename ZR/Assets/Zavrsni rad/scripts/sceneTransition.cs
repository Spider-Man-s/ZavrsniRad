using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class sceneTransition : MonoBehaviour {

    void OnEnable() {
        SceneManager.LoadScene("Demo", LoadSceneMode.Single);   
    }

}


