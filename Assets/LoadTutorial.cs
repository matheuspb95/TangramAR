using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
        int value = PlayerPrefs.GetInt("Openned");
        Debug.Log(value);
        if(value <= 0){
            SceneManager.LoadScene("Tutorial");
        }else{            
            SceneManager.LoadScene("Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
