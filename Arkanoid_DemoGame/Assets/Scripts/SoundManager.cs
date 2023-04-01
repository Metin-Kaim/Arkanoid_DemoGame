using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] AudioSource[] _audioSources;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);

    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += LoseSound;
        GameManager.Instance.OnWin += WinSound;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= LoseSound;
        GameManager.Instance.OnWin -= WinSound;
    }

    public void PlaySound(int index) // 0 = menu, 1 = win, 2 = lose, 3 = brick, 4 = shooter
    {
        _audioSources[index].Play();
    }

    public void StopSound(int index)
    {
        if (_audioSources[index].isPlaying)
            _audioSources[index].Stop();
    }

    public void WinSound()
    {
        _audioSources[1].Play();
    }
    public void LoseSound()
    {
        _audioSources[2].Play();
    }
}
