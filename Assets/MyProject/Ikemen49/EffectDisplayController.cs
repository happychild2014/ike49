using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDisplayController : MonoBehaviour {

    public float showTime;
    public float hideTime;
    public float currentTime = 0;
    public bool isShowed = false;
    public bool isHided = false;

    public GameObject TargetEffect;

	// Use this for initialization
	void Start () {
        TargetEffect.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if(showTime < currentTime && !isShowed)
        {
            TargetEffect.SetActive(true);
            isShowed = true;
        }else if(currentTime > hideTime && !isHided)
        {
            TargetEffect.SetActive(false);
            isHided = true;
        }
    }
}
