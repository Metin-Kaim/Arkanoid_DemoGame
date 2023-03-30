using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float velocity;
    [SerializeField] float multiVelocity;
    [SerializeField] GameObject _shooter;

    bool fixedXAxis = true;
    readonly float _boundary = 2.64f;
    bool needToFixXAxis = false;

    public bool NeedToFixXAxis { get => needToFixXAxis; set => needToFixXAxis = value; }


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        RandomLaunch();
    }
    private void Update()
    {
        if ((transform.position.x < -_boundary || transform.position.x > _boundary) && fixedXAxis)
        {
            fixedXAxis = false;
            StartCoroutine(FixingXAxis());
        }
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
}
