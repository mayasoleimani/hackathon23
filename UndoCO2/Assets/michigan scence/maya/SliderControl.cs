using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SliderControl : MonoBehaviour
{
    int n;
    public static float health = 10000000;
    public TMP_Text myText;
    public Slider mySlider;
    public static float ClickAmount = 1;
    public GameObject tree;
    public float x = .2F;
    float y = .2F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = health;
        myText.text = "CO2: " + health;

        if (health <= 0) {

            myText.text = "congrats you saved michigan ecosystem";
        }


        x = Mathf.Abs(Mathf.Clamp( (1/(((health - 0) / (10000000 - 0)) * .8F)),.3F , 2F ) );
            //(.8F / ((health) + .8F));
        tree.GetComponent<RectTransform>().localScale =new Vector3(x-1F,x - 1F, 1);
        if(health <= 0)
            tree.GetComponent<RectTransform>().localScale = new Vector3(1,1, 1);
        //   tree.scale.y = 1;

    }




    public void GainHealth()
    {

        
        health = health - ClickAmount;
        shopScript.totaloygxen += ClickAmount;
    }
}
