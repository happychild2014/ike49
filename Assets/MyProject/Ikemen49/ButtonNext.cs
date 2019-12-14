using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNext : MonoBehaviour {


    public void TestCall()
    {
        Debug.Log("Hello Unity");


        SceneManager.LoadScene("Scene2");
    }
}

