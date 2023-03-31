using UnityEngine;

public class WinLoseController : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] GameObject _shooter;

    bool isIn = false;

    private void Update()
    {
        if (_ball.transform.position.y < _shooter.transform.position.y - 1 && !isIn)
        {
            isIn = true;
            GameManager.Instance.IsGameOver = true; //Game Over
        }
        else if (Brick.TotalBrick <= 0 && !isIn)//Next Level
        {
            isIn = true;
            GameManager.Instance.IsWin = true; //Winner winner chicken dinner...
        }
    }
}
