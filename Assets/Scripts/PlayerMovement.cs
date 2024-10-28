using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _movement;
    [SerializeField]private float _speed;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()  // Fps De�erine g�re �al���r
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // Rb pozisyonuna ekleyerek yap�yoruz
    }

    private void FixedUpdate()  // 60 Fps sabit kal�r
    {
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);

    }


}
