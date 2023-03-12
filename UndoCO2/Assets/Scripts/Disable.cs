using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class disable : MonoBehaviour
{

    //GUI btn = (GameObject)Instantiate(Resources.Load("MyButton"));

    //GameObject btn = GameObject.CreatePrimitive(PrimitiveType.Plane);
    //public Object btn = Object.Instantiate(Resources.Load("MyButton"));
    //public Color newColor;
    //public Button mybutton;
    //public Color newColor;

    public Sprite blockA;
    public Sprite blockA_disable;
    public bool condition;
    public Button mybutton;
    public int counter;

    void start()
    {
        mybutton = GetComponent<Button>();
    }

    public void changebutton()
    {
        counter++;
        if (counter % 2 == 0)
        {
            mybutton.image.overrideSprite = blockA;
        }
        else
        {
            mybutton.image.overrideSprite = blockA_disable;
        }

    }

}
