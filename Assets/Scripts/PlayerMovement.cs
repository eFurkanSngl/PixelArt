using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _movement;
    private float _InputHorz;
    private float _InputVert;
    [SerializeField]private float _speed;
    [SerializeField] Animator _anim;

    private bool _facingRight = true;   

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()  // Fps De�erine g�re �al���r
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // Rb pozisyonuna ekleyerek yap�yoruz


        //_InputHorz = Input.GetAxisRaw("Horizontal");
        //_InputVert = Input.GetAxisRaw("Vertical");
        //_movement= new Vector2(_InputHorz,_InputVert);

        if (Input.GetButtonDown("Fire1")) // Mouse Button 0 yani sol t�k
        {
            _anim.SetTrigger("isAttack");
        } // her framde cal��mas� i�in Update'e yazd�k


    }
    private void FixedUpdate()  // 60 Fps sabit kal�r
    {
        #region Movement
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);


        if(_movement.x < 0 && _facingRight)
        {
             Flip();
             _facingRight = !_facingRight;
             // flip att�k ve art�k sola d�nd�rd�k false oldu
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
            // E�er karakter.y ve .x sabit de�ilse True olarak set et

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
