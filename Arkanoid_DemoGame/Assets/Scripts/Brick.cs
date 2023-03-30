using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] BrickSO _brickSO;

    float _health;

    private void Start()
    {
        _health = _brickSO.health;
    }

    private void Update()
    {
        if (_health == 0)
            Destroy(gameObject);
    }

    public void DecreaseHealth()
    {
        _health--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _health--;
    }
}
