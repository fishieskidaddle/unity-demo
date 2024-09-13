using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour
{
    public Slider health;
    // Start is called before the first frame update
    void Start()

    {
        health.value = 1f;
        health.maxValue = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
