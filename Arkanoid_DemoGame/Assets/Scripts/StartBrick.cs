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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _ball.gameObject.SetActive(false);
        _shooter.gameObject.SetActive(false);
        //_ball.CanMove = false;
        //_ball.VelocityOfBallisZero();
        //_ball.transform.parent = _shooter.transform;
        //_ball.transform.localPosition = Vector2.Lerp(_ball.transform.position, new Vector2(0, 1.12f), 1f);
        //_shooter.CanMove = false;
        _animator.SetTrigger("Begin");
    }

    public void LoadLevel()
    {
        GameManager.Instance.LoadLevelScene(1); //TODO: son kaydedilen leveli al.
    }
}
