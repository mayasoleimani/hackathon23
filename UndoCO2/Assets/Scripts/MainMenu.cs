using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public bool easyDone = false;
    public bool normalDone = false;
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public Button mediumBtn;
    public Button brutalBtn;
    
    public void Easy()
	{
        SceneManager.LoadScene(1);
        easyDone = true;

	}
   
    public void Medium()
    {
        //SceneManagement.LoadScene(2);
    }

    public void Brutal()
	{
        //SceneManagement.LoadScene(3)
	}

    public void Update()
	{
        if (easyDone)
		{
            mediumBtn.enabled = true;
		}
        else
		{
            mediumBtn.enabled = false;
		}
        
        if (normalDone)
		{
            brutalBtn.enabled = true;
		}
		else
		{
            brutalBtn.enabled = false;
		}
	}

}
