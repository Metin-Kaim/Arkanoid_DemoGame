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
        SoundManager.Instance.PlaySound(0); //menu
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.Instance.PlaySound(3);
        _ball.gameObject.SetActive(false);
        _shooter.gameObject.SetActive(false);

        _animator.SetTrigger("Begin");
    }

    public void LoadLevel()
    {
        SoundManager.Instance.StopSound(0);
        GameManager.Instance.LoadLevelScene(1); //TODO: son kaydedilen leveli al.
    }
}
