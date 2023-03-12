using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class shopScript : MonoBehaviour
{
    public float total = 1;
    public TMP_Text textMesh;
    public Object[] obj = new Object[14];
     static GameObject selectedButton;

    public float totalclickamount = 1;
    public float passiveamountgenerated = 0;
    public static float totaloygxen = 0;
    public TMP_Text oxyg;
    public float timeremaining = 1;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timeremaining > 0)
        {
            timeremaining -= Time.deltaTime;
        }
        else
        {

            totaloygxen += passiveamountgenerated;
            oxyg.text = totaloygxen.ToString();
            timeremaining = 1;
            // Debug.Log(passiveamountgenerated);
            SliderControl.health = SliderControl.health - passiveamountgenerated;
        }
    }






    public void itembuy() {
        shopScript.selectedButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int ClickedButtonName = int.Parse(selectedButton.name);
        total += 1;
       // Debug.Log(ClickedButtonName + " "+ total);

        switch (ClickedButtonName) {
            case 1:
                if (totaloygxen >= 10) {
                    totaloygxen -= 10;
                    totalclickamount += 1;
                }
                break;
            case 2:
                if (totaloygxen >= 100)
                {
                    totaloygxen -= 100;
                    passiveamountgenerated += 5;
                }
                break;
            case 3:
                if (totaloygxen >= 1000)
                {
                    totaloygxen -= 1000;
                    totalclickamount += 50;
                }
                break;
            case 4:
                if (totaloygxen >= 10000)
                {
                    totaloygxen -= 10000;
                    passiveamountgenerated += 500;
                }
                break;
            case 5:
                if (totaloygxen >= 100000)
                {
                    totaloygxen -= 100000;
                    totalclickamount += 5000;
                }
                break;
            case 6:
                if (totaloygxen >= 1000000)
                {
                    totaloygxen -= 1000000;
                    passiveamountgenerated += 50000;
                }
                break;
            case 7:
                if (totaloygxen >= 10000000)
                {
                    totaloygxen -= 10000000;
                    totalclickamount += 500000;
                }
                break;
            case 8:
                if (totaloygxen >= 100000000)
                {
                    totaloygxen -= 100000000;
                    passiveamountgenerated += 500000;
                }
                break;
            case 9:
                if (totaloygxen >= 1000000000)
                {
                    totaloygxen -= 1000000000;
                    totalclickamount += 50000000;
                }
                break;
            case 10:
                if (totaloygxen >= 10000000000)
                {
                    totaloygxen -= 10000000000;
                    passiveamountgenerated += 500000000;
                }
                break;
                    default:
                break;
        }
        oxyg.text = totaloygxen.ToString();
        SliderControl.ClickAmount = totalclickamount;
    }
}
