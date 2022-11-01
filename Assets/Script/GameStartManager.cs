using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartManager : MonoBehaviour
{
    public static GameStartManager Instance;

    [SerializeField]
    private GameObject GameStartUI;
    //[SerializeField]
    //private GameObject GameOverUI;

    bool startGame = false;

    StartButton startBtn = new StartButton();


    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        GameStartUI.SetActive(true);
    }

    private void Update()
    {
        if (startGame == false)
        {
            if (startBtn.OnClickStart())
            {
                startGame = true;
                Time.timeScale = 1f;
                GameStartUI.SetActive(false);
            }
        }
    }

    public void GameOver()
    {
        GameStartUI.SetActive(true);
    }

    public void Restart()
    {
        startGame = false;
        GameStartUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
