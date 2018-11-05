using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaunto : MonoBehaviour {
    private const int peaceline = 5;
    private const int peacecol = 5;
    private const float peaceW = 300f;
    private const float peaceH = 280f;
    private const float FpeaceX = -600f;
    private const float FpeaceY = -840f;

    private GameObject[,] peaceS;
    private int[,] objN;


    public Text scoreT;
    public Text timeT;
    public static int point = 0;
    public static float time = 0;
    public static float Retime = 0;
    public static int[] peaceNum = new int[12];
    public static bool[] story = new bool[12];
    public static int H_point = 0;
    public static int T_point = 0;
    public static int M_point = 0;

    private AudioSource Auso;
    private static bool[] zissekiB = new bool[30];


    public static bool ziseki(int num)
    {
        switch (num)
        {
            case 0:
                if (Retime < 1000)
                {
                    return false;
                   
                }
                else
                {
                    
                    return true;
                    
                }
                
            case 1:
                if (H_point < 3)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 2:
                if (M_point < 3)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 3:
                if (T_point < 3)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 4:
                if (H_point < 10)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 5:
                if (M_point < 10)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 6:
                if (T_point < 10)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                    
                }
            case 7:
                if (H_point < 20)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 8:
                if (M_point < 20)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 9:
                if (T_point < 20)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 10:
                if (H_point < 35)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 11:
                if (M_point < 35)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 12:
                if (T_point < 35)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 13:
                if (H_point < 40)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 14:
                if (M_point < 40)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            case 15:
                if (T_point < 40)
                {
                    return false;

                }
                else
                {
                    return true;

                }
        }
       
        return false;
    }
   
    void AudioZ()
    {
        if (Retime > 1000 && zissekiB[0] ==false)
        {
            Invoke("disAu", 1f);
            zissekiB[0] = true;
        }
        if (H_point == 3 && zissekiB[1] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[1] = true;
        }
        if (M_point == 3 && zissekiB[2] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[2] = true;
        }
        if (T_point == 3 && zissekiB[3] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[3] = true;
        }
        if (H_point == 10 && zissekiB[4] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[4] = true;
        }
        if (M_point == 10 && zissekiB[5] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[5] = true;
        }
        if (T_point == 10 && zissekiB[6] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[7] = true;
        }
        if (H_point == 20 && zissekiB[7] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[8] = true;
        }
        if (M_point == 20 && zissekiB[8] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[9] = true;
        }
        if (T_point == 20 && zissekiB[9] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[10] = true;
        }
        if (H_point == 35 && zissekiB[10] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[11] = true;
        }
        if (M_point == 35 && zissekiB[11] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[12] = true;
        }
        if (T_point == 35 && zissekiB[12] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[13] = true;
        }
        if (H_point == 40 && zissekiB[13] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[14] = true;
        }
        if (M_point == 40 && zissekiB[14] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[15] = true;
        }
        if (T_point == 40 && zissekiB[15] == false)
        {
            Invoke("disAu", 1f);
            zissekiB[6] = true;
        }
    }
    void disAu()
    {
        Auso.PlayOneShot(Auso.clip);
    }
    
    // Use this for initialization
    void Start () {
        Auso = GetComponent<AudioSource>();
        SpeaceS();
        hensu();
        
    }
	
	// Update is called once per frame
	void Update () {
        SpeaceS();
        hensu();
        lapse();
        AudioZ();
        scoreT.text = "消した種族数" + point.ToString();

        Debug.Log(H_point+","+T_point+","+M_point);

        
    }
    private void SpeaceS()
    {
        GameObject[,] peaceS = new GameObject[peaceline, peacecol];

        for (int i = 0; i < peaceline; i++)
        {
            for (int j = 0; j < peacecol; j++)
            {
                Collider2D col = Physics2D.OverlapPoint(new Vector2(FpeaceX + peaceW * j, FpeaceY + peaceH * i));
                if ("peace".Equals(col.tag))
                {
                    peaceS[i, j] = col.gameObject;
                    
                }
            }
        }
        this.peaceS = peaceS;
    }
    private void hensu()
    {
        int[,] objN = new int[peaceline, peacecol];
        for (int i = 0; i < peaceline; i++)
        {
            for (int j = 0; j < peacecol; j++)
            {
                peace SCpeace = this.peaceS[i, j].GetComponent<peace>();
                objN[i, j] = SCpeace.GetSpr();
            }
        }
        
        this.objN = objN;
    }
    public void pointP()
    {
        point += 1000;
    }

    public int LeIn (int a)
    {
        int lenI=0;
        for (int i = 0; i < peaceline; i++)
        {
            for (int j = 0; j < peacecol; j++)
            {
                if (this.objN[i, j] == a)
                {
                    lenI++;
                }
            }
        }
                return lenI;
    }
    private void lapse()
    {
        time += Time.deltaTime;
        Retime += Time.deltaTime; 
        int deb = (int)Retime % 60;
        int nen = (int)(time / 20) + 1;

        if (Input.GetMouseButtonDown(0))
        {
            Retime = 0;
        }
        timeT.text = nen+ "年目";
        
    }
   public void syuzokuti(int suti)
    {
        if(suti == 0)
        {
            H_point += 1;
        }
        else if (suti == 1)
        {
            M_point += 1;
        }
        else if (suti == 2)
        {
            T_point += 1;
        }
    }
   

}
