using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_menu : MonoBehaviour
{

    public GameObject pausemenu;
    bool gamepaused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (gamepaused)
                Resume();
            else
                pausegame();
        
        }


    }





    public void Resume() {


        pausemenu.SetActive(false);
    
    }


    public void pausegame() {

        pausemenu.SetActive(true);
    }


    public void quitmen() {

        SceneManager.LoadScene(0);


    }



}
