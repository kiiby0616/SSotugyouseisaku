using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mawasu : MonoBehaviour
{
    private float time;
    public float speedZ = 0;
    private Vector3 speed;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        speed = new Vector3(0, 0, time * speedZ);
        transform.eulerAngles += speed;
    }
}
