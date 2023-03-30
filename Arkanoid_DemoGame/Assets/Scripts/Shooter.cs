using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    InputActions _inputActions;
    Ball _ball;

    private void Awake()
    {
        _ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
    }

    private void Start()
    {
        _inputActions = new();
        _inputActions.Shooter.Enable();
    }
    private void Update()
    {
        float moveDir = _inputActions.Shooter.Movement.ReadValue<float>();
        transform.Translate(moveDir * _moveSpeed * Time.deltaTime * Vector3.right);

        float posX = Mathf.Clamp(transform.position.x, -2, +2);
        transform.position = new Vector3(posX, transform.position.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && _ball.NeedToFixXAxis)
        {
            _ball.NeedToFixXAxis = false;
            _ball.RandomLaunch();
        }
    }
    
}
