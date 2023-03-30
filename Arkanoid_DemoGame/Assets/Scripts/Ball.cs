using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float velocity;
    [SerializeField] float multiVelocity;

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
        if (Input.GetKeyDown(KeyCode.K))
        {
            rb.velocity *= multiVelocity;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            rb.velocity /= multiVelocity;
        }

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
            min = -1f;
            max = 0;
        }
        else if (transform.position.x < -2)
        {
            min = 0f;
            max = 1f;
        }
        else
        {
            min = -1f;
            max = 1f;
        }

        GetRandomVector2(min, max);
    }
    void GetRandomVector2(float min = -1f, float max = 1f)
    {
        rb.velocity = Time.deltaTime * velocity * new Vector2(Random.Range(min, max), 1);
    }
}
