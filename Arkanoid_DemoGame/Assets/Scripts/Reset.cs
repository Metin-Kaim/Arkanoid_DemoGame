using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.LoadLevelScene("Menu");
    }
}
