using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] float multiVelocity;
    [SerializeField] GameObject _shooter;

    bool fixedXAxis = true;
    readonly float _boundary = 2.64f;
    bool needToFixXAxis = false;
    bool isGameStart = false;

    Rigidbody2D rb;
    InputActions _inputActions;

    public bool NeedToFixXAxis { get => needToFixXAxis; set => needToFixXAxis = value; }
    public bool CanMove { get; set; }


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _inputActions = GameManager.Instance.InputActions;
        transform.parent = _shooter.transform;
        VelocityOfBallisZero();
        CanMove = true;
    }
    private void Update()
    {
        if (!CanMove) return;

        float isButtonPressed = _inputActions.Shooter.Launcher.ReadValue<float>();

        if (isButtonPressed == 1 && !isGameStart) //top firlatildi ve oyun basladi
        {
            isGameStart = true;
            transform.parent = null; //topun parent'ý sýfýrlandý
            RandomLaunch();
        }

        if ((transform.position.x < -_boundary || transform.position.x > _boundary) && fixedXAxis)
        {
            fixedXAxis = false;
            StartCoroutine(FixingXAxis());
        }


    }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += VelocityOfBallisZero;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= VelocityOfBallisZero;
    }

    IEnumerator FixingXAxis()
    {
        yield return new WaitForSeconds(2f);
        if (transform.position.x < -_boundary || transform.position.x > _boundary)
        {
            needToFixXAxis = true;
        }
        yield return new WaitForSeconds(1f);
        fixedXAxis = true;
    }
    public void RandomLaunch()
    {
        float min, max;

        if (transform.position.x > 2)
        {
            min = -2f;
            max = 0;
        }
        else if (transform.position.x < -2)
        {
            min = 0f;
            max = 2f;
        }
        else
        {
            min = -2f;
            max = 2f;
        }

        GetRandomVector2(min, max);
    }
    void GetRandomVector2(float min = -1f, float max = 1f)
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(Random.Range(min, max), 1 * velocity), ForceMode2D.Impulse);
    }

    public void VelocityOfBallisZero()
    {
        rb.velocity = Vector2.zero;
    }
}
