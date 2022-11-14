using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 40;
    public Text textotimer;
    
    void Update()
    {
        textotimer.text = "" + timer.ToString("f0");
            
        if (timer <= 9)
        {
            textotimer.text = "0" + timer.ToString("f0");
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            textotimer.text = "El tiempo se acabó";
        }
        
    }
}
