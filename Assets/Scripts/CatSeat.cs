using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSeat : MonoBehaviour
{
    [SerializeField] private Transform _lineStartPosition, _lineEndPosition;
    [SerializeField] private Sprite _activatedSprite, _deactivatedSprite;

    private LineRenderer _lineRenderer;
    private SpriteRenderer _spriteRenderer;
    private bool _ativated = false;

    public bool Activated => _ativated;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _lineRenderer.SetPosition(index: 0, _lineStartPosition.position);
        _lineRenderer.SetPosition(index: 1, _lineEndPosition.position);
    }

    public void Activate()
    {
        _spriteRenderer.sprite = _activatedSprite;
        _ativated = true;
    }

    public void Deactivate()
    {
        _spriteRenderer.sprite = _deactivatedSprite;
    }
}
