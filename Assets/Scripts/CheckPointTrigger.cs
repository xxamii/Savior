using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _checkPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Cat>() && !_checkPoint.GetComponent<CheckPoint>().IsActivated)
        {
            _checkPoint.GetComponent<CheckPoint>().Activate();
        }
    }
}
