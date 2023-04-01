using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] GameObject _winPanel;

    private void Awake()
    {
        _winPanel.SetActive(false);
        _gameOverPanel.SetActive(false);
    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnGameOver;
        GameManager.Instance.OnWin += HandleOnWin;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnGameOver;
        GameManager.Instance.OnWin -= HandleOnWin;
    }
    private void HandleOnGameOver()
    {
        if (!_gameOverPanel.activeInHierarchy)
            _gameOverPanel.SetActive(true);
    }

    private void HandleOnWin()
    {
        if (!_winPanel.activeInHierarchy)
            _winPanel.SetActive(true);
    }

    public void LevelLoader(int index) //win-lose butonlarýna verildi.
    {
        Brick.TotalBrick = 0;
        GameManager.Instance.LoadLevelScene(index);
    }
}
