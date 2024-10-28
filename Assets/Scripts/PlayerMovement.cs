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
    void Update()  // Fps Deðerine göre çalýþýr
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // Rb pozisyonuna ekleyerek yapýyoruz
    }

    private void FixedUpdate()  // 60 Fps sabit kalýr
    {
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);

    }


}
