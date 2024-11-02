using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _movement;
    [SerializeField]private float _speed;
    [SerializeField] Animator _anim;

    private bool _facingRight = true;   

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()  // Fps Deðerine göre çalýþýr
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // Rb pozisyonuna ekleyerek yapýyoruz


        if (Input.GetButtonDown("Fire1")) // Mouse Button 0 yani sol týk
        {
            _anim.SetTrigger("isAttack");
        } // her framde calýþmasý için Update'e yazdýk


    }
    private void FixedUpdate()  // 60 Fps sabit kalýr
    {
        #region Movement
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);
        if(_movement.x < 0 && _facingRight)
        {
             Flip();
             _facingRight = !_facingRight;
             // flip attýk ve artýk sola döndürdük false oldu
        }

        else if(_movement.x > 0 && !_facingRight)
        {
            Flip();
            _facingRight = !_facingRight;
        }
        #endregion

        #region Anim
        if (_movement.y != 0 || _movement.x != 0)
        {
            _anim.SetBool("isRunnig", true);
            // Eðer karakter.y ve .x sabit deðilse True olarak set et

        }
        else
        {
            _anim.SetBool("isRunnig", false);
        }

        #endregion
    }
    private void Flip()
    {
        transform.Rotate(new Vector3(0,180,0));
    }

}
