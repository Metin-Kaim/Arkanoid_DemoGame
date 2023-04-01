using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] AudioSource _menuSound1;
    [SerializeField] AudioSource _menuSound2;
    [SerializeField] AudioSource _winSound;
    [SerializeField] AudioSource _loseSound;
    [SerializeField] AudioSource _brickSound;
    [SerializeField] AudioSource _shooterSound;

    public AudioSource MenuSound1 => _menuSound1;
    public AudioSource MenuSound2 => _menuSound2;
    public AudioSource WinSound => _winSound;
    public AudioSource LoseSound => _loseSound;
    public AudioSource BrickSound => _brickSound;
    public AudioSource ShooterSound => _shooterSound;

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
        GameManager.Instance.OnGameOver += LoseSoundPlayer;
        GameManager.Instance.OnWin += WinSoundPlayer;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= LoseSoundPlayer;
        GameManager.Instance.OnWin -= WinSoundPlayer;
    }

    private void WinSoundPlayer()
    {
        _winSound.Play();
    }
    private void LoseSoundPlayer()
    {
        _loseSound.Play();
    }

    public void MenuSound1Player(int soundState)
    {
        SoundController(soundState, MenuSound1);
    }
    public void MenuSound2Player(int soundState)
    {
        SoundController(soundState, MenuSound2);
    }
    public void BrickSoundPlayer(int soundState)
    {
        SoundController(soundState, BrickSound);
    }
    public void ShooterSoundPlayer(int soundState)
    {
        SoundController(soundState, ShooterSound);
}

    private void SoundController(int soundState, AudioSource audioSource)
    {
        if (soundState == 0)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}
