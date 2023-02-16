using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameOver;
    public static bool levelCompleted;
    public GameObject gameOverPanel;
    public GameObject levelCompletedPanel;
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        levelCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("Level");
            }

        }
        if (levelCompleted)
        {
            Time.timeScale = 0;
            levelCompletedPanel.SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("Level");
            }
        }

    }
}
