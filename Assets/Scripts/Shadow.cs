using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public SpriteRenderer _spriteRenderer;
    public Color normalColor;
    public Color shadowColor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _spriteRenderer.color = shadowColor;
        }
        // Eðer Player Ýle etkiliþime girdiyse Shadow yap
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _spriteRenderer.color = normalColor;
        }
        // Eðer Player Ýle etkileþimden çýktýysa normal renge dön.
    }
}
