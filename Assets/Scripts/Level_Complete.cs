using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour
{
    public void LoadNextLevel() // Creating a function to call it as an event in animation tab.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
