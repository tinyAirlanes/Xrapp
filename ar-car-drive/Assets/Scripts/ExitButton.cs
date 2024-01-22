using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


namespace UnityEngine.XR.ARFoundation.Samples
{
    public class ExitButton : MonoBehaviour
    {
        public GameObject appMgmt;

        public void QuitGame()
        {
            // Save the score only if it is bigger then the previous max
            if (Application.isPlaying)
            {
                if (Score.scoreCount > Score.oldScoreCount)
                {
                    appMgmt.GetComponent<updateDB>().updateDatabase("playerData");
                    Debug.Log("You have reached a new score!");
                }
                Application.Quit();
            }
        }
    }
}
