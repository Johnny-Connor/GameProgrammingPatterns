using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private void Update()
    {
        void ReloadScene()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Debug.Log("Scene reloaded.");
        }

        void ShowClickCount()
        {
            Debug.Log("Click count: " + ClickCounter.GetInstance().GetClicks() + ".");
        }

        if (Input.GetMouseButtonDown(1)) // M2
        {
            ReloadScene();
            ShowClickCount();
        }
    }
}
