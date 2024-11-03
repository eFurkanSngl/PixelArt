using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]private Transform _targetPos;  // hedef Poz almak i�in
    private Vector3 _offset; // Kendi uzakl���n� tutmas� i�in Vector3.
    [SerializeField] private float _smoothedSpeed = 0.125f;

    void Start()
    {
        _offset = transform.position - _targetPos.position;
        // Kendi Poz ile Hedef poz aras�nda ki uzakl��� buluyor.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offset + _targetPos.position, _smoothedSpeed);
        // Lerp i�in Kendi Poz , ba�lang��ta uzakl��� ile anl�k uzakl���n� topluyor hedef poz ile , h�z ile yumu�at�yor
        this.transform.position = newPos;
        // kendi transformuna newPosu at�yoruz
    }
}
