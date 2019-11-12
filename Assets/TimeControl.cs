using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public Text text;
    public int tempo;
    public bool running = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddTime", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRunning(){
        running = !running;
    }

    public void AddTime(){
        if(running){
            tempo++;
            text.text = string.Format("{0:D2}:{1:D2}", tempo/60, tempo%60);
        }
    }
}
