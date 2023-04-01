using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] BrickSO _brickSO;

    public static int TotalBrick;

    float _health;

    private void Start()
    {
        _health = _brickSO.health;
        TotalBrick++;
    }

    private void Update()
    {
        if (_health == 0)
        {
            TotalBrick--;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.Instance.PlaySound(3);
        _health--;
    }
}
