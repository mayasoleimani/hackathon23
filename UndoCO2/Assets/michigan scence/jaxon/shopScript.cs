using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class shopScript : MonoBehaviour
{
    public int total = 1;
    public TextMeshPro textMesh;
    public Object[] obj = new Object[14];
     static GameObject selectedButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }


    public void itembuy() {
        shopScript.selectedButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int ClickedButtonName = int.Parse(selectedButton.name);
        total += 1;
        Debug.Log(ClickedButtonName + " "+ total);

        switch (ClickedButtonName) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            default:
        }
    
    }
}
