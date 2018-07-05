using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {

    public GameObject boxes;
    bool levelOneTriggered, levelTwoTriggered, levelThreeTriggered, triggerWin;

	void Update () {
        boxes = GameObject.FindWithTag("Box");
        
            if(boxes == null && levelOneTriggered == true)
            {
                SceneManager.LoadScene("Level 2");
                levelTwoTriggered = true;
            }

            if (boxes == null && levelOneTriggered == true && levelTwoTriggered == true)
            {
                SceneManager.LoadScene("Level 3");
                levelThreeTriggered = true;
            }

            if (boxes == null && levelOneTriggered == true && levelTwoTriggered == true && levelThreeTriggered == true)
            {
                SceneManager.LoadScene("Win");
                triggerWin = true;
            }
        if (boxes == null && levelOneTriggered == true && levelTwoTriggered == true && levelThreeTriggered == true)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
