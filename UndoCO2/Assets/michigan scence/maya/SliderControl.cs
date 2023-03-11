using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderControl : MonoBehaviour
{
    int n;
    public TextMeshPro myText;
    public Slider mySlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Current Value: " + mySlider.value;
    }
}
