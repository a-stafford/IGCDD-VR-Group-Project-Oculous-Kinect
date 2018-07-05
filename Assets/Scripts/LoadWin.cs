using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadWin : MonoBehaviour {

    public GameObject boxes;
    public GameObject character;

    void Update () {
        boxes = GameObject.FindWithTag("Box");

        if (boxes == null)
        {
            SceneManager.LoadScene("Win");
            die();
        }
    }

    void die()
    {
        Destroy(character);
    }
}
