using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Text text;

    public void setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void sethealth(int health)
    {
        slider.value = health;
        text.text = string.Format("{0} / {1}", health, slider.maxValue);
    }
}
