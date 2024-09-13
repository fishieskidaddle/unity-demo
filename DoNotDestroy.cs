using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if( musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
