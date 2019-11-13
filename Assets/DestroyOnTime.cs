using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyTime", time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyTime(){
        Destroy(this.gameObject);
    }
}
