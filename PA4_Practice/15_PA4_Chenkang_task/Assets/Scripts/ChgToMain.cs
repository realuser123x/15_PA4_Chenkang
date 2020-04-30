using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChgToMain : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        {
            StartCoroutine(WaitForIt(3.0F));
        }
        IEnumerator WaitForIt(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(1);
        }
    }
}
