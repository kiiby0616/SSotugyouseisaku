using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zisseki : MonoBehaviour {
    bool[] storyN = new bool[30];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        storyN[0] = kaunto.ziseki(0);
        canvas.SetInteractive("story", storyN[0]);
        storyN[1] = kaunto.ziseki(1);
        canvas.SetInteractive("storyH1", storyN[1]);
        storyN[2] = kaunto.ziseki(2);
        canvas.SetInteractive("storyM1", storyN[2]);
        storyN[3] = kaunto.ziseki(3);
        canvas.SetInteractive("storyT1", storyN[3]);
        storyN[4] = kaunto.ziseki(4);
        canvas.SetInteractive("storyH2", storyN[4]);
        storyN[5] = kaunto.ziseki(5);
        canvas.SetInteractive("storyM2", storyN[5]);
        storyN[6] = kaunto.ziseki(6);
        canvas.SetInteractive("storyT2", storyN[6]);
        storyN[7] = kaunto.ziseki(7);
        canvas.SetInteractive("storyH3", storyN[7]);
        storyN[8] = kaunto.ziseki(8);
        canvas.SetInteractive("storyM3", storyN[8]);
        storyN[9] = kaunto.ziseki(9);
        canvas.SetInteractive("storyT3", storyN[9]);
        storyN[10] = kaunto.ziseki(10);
        canvas.SetInteractive("storyH4", storyN[10]);
        storyN[11] = kaunto.ziseki(11);
        canvas.SetInteractive("storyM4", storyN[11]);
        storyN[12] = kaunto.ziseki(12);
        canvas.SetInteractive("storyT4", storyN[12]);
        storyN[13] = kaunto.ziseki(13);
        canvas.SetInteractive("storyH5", storyN[13]);
        storyN[14] = kaunto.ziseki(14);
        canvas.SetInteractive("storyM5", storyN[14]);
        storyN[15] = kaunto.ziseki(15);
        canvas.SetInteractive("storyT5", storyN[15]);
    }
}
