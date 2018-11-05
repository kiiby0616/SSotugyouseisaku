using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touka : MonoBehaviour {
    SpriteRenderer spre;
    public float toukasuti = 0.4f;
    
	// Use this for initialization
	void Start () {
        this.spre = GetComponent<SpriteRenderer>();
        chantrans(toukasuti);
	}
	void chantrans(float a)
    {
        this.spre.color = new Color(1, 1, 1, a);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
