using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderControl : MonoBehaviour
{
    int n;
    public static float health= 10000000;
    public TMP_Text myText;
    public Slider mySlider;
    public static float ClickAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = health;
        myText.text = "CO2: " + health;

        if (health <= 0)
        {

            myText.text = "congrats you saved michigan ecosystem";
        }

    }

    
    

    public void GainHealth()
    {
        health = health - ClickAmount;
        shopScript.totaloygxen += ClickAmount;
    }

    
}

