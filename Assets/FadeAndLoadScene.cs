using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeAndLoadScene : MonoBehaviour
{
    public Image FadePanel;
    public float fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string scene){
        StartCoroutine(Fade(scene));
    }

    IEnumerator Fade(string scene){
        float t = 0;
        while(t < 1){
            t += Time.fixedDeltaTime / fadeTime;
            FadePanel.color = new Color(0,0,0,t);
            yield return new WaitForFixedUpdate();
        }
        SceneManager.LoadScene(scene);
    }
}
