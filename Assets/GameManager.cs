
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool isGameOver = false;
    public GameObject gameOverUI;

    public void GameOver()
    {
        if (isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("Gameover");
            gameOverUI.SetActive(true);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }
    }
}
