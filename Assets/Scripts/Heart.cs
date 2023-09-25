using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private AudioClip _healSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CatHealth>() && collision.GetComponent<CatHealth>().Amount < 3)
        {
            collision.GetComponent<CatHealth>().AddHealth();
            AudioSource.PlayClipAtPoint(_healSound, Camera.main.transform.position);
            Destroy(this.gameObject);
        }
    }
}
