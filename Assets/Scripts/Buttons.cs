using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.CompareTag("Menu"))
            {
                Debug.Log("Works");
                mainMenu();
            }

        if (other.gameObject.CompareTag("Start"))
        {
            Debug.Log("Works");
            startLevel();
        }


        if (other.gameObject.CompareTag("Exit"))
        {
            if (other.gameObject.CompareTag("Exit") )
            {
                Debug.Log("Works");
                exitGame();
            }
        }
    }


    public void exitGame()
    {
        Application.Quit();
    }

    public void startLevel()
    {
        SceneManager.LoadScene("Level 1");

    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }


}
