using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    Ball _ball;
    InputActions _inputActions;
    Animator _animator;

    public bool CanMove { get; set; }

    private void Awake()
    {
        _ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _inputActions = GameManager.Instance.InputActions;
        _inputActions.Shooter.Enable();

        CanMove = true;
    }
    private void Update()
    {
        if (!CanMove) return;

        float moveDir = _inputActions.Shooter.Movement.ReadValue<float>();

        transform.Translate(moveDir * _moveSpeed * Time.deltaTime * Vector3.right);

        float posX = Mathf.Clamp(transform.position.x, -2, +2);
        transform.position = new Vector3(posX, transform.position.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.Instance.ShooterSoundPlayer(1);

        _animator.SetTrigger("Shoot");

        if (collision.gameObject.CompareTag("Ball") && _ball.NeedToFixXAxis)
        {
            _ball.NeedToFixXAxis = false;
            _ball.RandomLaunch();
        }
    }

}
