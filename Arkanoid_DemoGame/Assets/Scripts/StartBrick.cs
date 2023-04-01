using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBrick : MonoBehaviour
{
    Animator _animator;
    [SerializeField] Ball _ball;
    [SerializeField] Shooter _shooter;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        SoundManager.Instance.MenuSound1Player(1); //menu
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.Instance.BrickSoundPlayer(1);
        _ball.gameObject.SetActive(false);
        _shooter.gameObject.SetActive(false);

        SoundManager.Instance.MenuSound1Player(0);
        _animator.SetTrigger("Begin");
    }

    public void LoadLevel()
    {
        GameManager.Instance.LoadLevelScene(1); //TODO: son kaydedilen leveli al.
    }

    public void MenuSound2Player(int soundState) // start brick animasyonunun içine eklendi. (play and stop)
    {
        SoundManager.Instance.MenuSound2Player(soundState);
    }
}
