using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public int selected = 0;
    public GameObject[] panels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            if(selected < panels.Length-1){
                panels[selected].SetActive(false);
                selected++;
                panels[selected].SetActive(true);
            }
        }
    }
}
