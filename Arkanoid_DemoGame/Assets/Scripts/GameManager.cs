using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsGameOver { get; set; }
    public bool IsWin { get; set; }
    public InputActions InputActions { get; private set; }


    public event System.Action OnGameOver;
    public event System.Action OnWin;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);

        InputActions = new();

    }

    private void Update()
    {
        if (IsGameOver)
        {
            IsGameOver = false;
            GameOverInvoke();
        }
        else if (IsWin)
        {
            IsWin = false;
            WinInvoke();
        }


    }

    private void OnEnable()
    {
        OnGameOver += TimeStop;
        OnWin += TimeStop;
    }
    private void OnDisable()
    {
        OnGameOver -= TimeStop;
        OnWin -= TimeStop;
    }

    private void GameOverInvoke()
    {
        OnGameOver?.Invoke();
    }

    private void WinInvoke()
    {
        OnWin?.Invoke();
    }

    private void TimeStop()
    {
        Time.timeScale = 0;
    }


    #region LoadLevelScene w/int
    public void LoadLevelScene(int levelIndex = 0)
    {
        StartCoroutine(LoadLevelSceneAsync(levelIndex));
    }
    IEnumerator LoadLevelSceneAsync(int levelIndex)
    {
        yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        Time.timeScale = 1;
    }
    #endregion

    #region LoadLevelScene w/string
    public void LoadLevelScene(string levelIndex)
    {
        StartCoroutine(LoadLevelSceneAsync(levelIndex));
    }
    IEnumerator LoadLevelSceneAsync(string levelIndex)
    {
        yield return SceneManager.LoadSceneAsync(levelIndex);
        Time.timeScale = 1;
    }
    #endregion
}