using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Slider HealthBar;

    public GameObject  button;

    public void OnClick()
    {
        HealthBar.value -= 0.2f;

    } 
}
