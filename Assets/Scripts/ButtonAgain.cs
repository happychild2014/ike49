using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {	
	}
	

    public void TestCall()
    {  
       SceneManager.LoadScene("Scene1");
    }
}


