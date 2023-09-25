using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.bodyType = RigidbodyType2D.Static;
    }

    public void Fall()
    {
        _rigidBody.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject, 0.1f);
    }
}
