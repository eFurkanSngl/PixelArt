using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]private Transform _targetPos;  // hedef Poz almak için
    private Vector3 _offset; // Kendi uzaklýðýný tutmasý için Vector3.
    [SerializeField] private float _smoothedSpeed = 0.125f;

    void Start()
    {
        _offset = transform.position - _targetPos.position;
        // Kendi Poz ile Hedef poz arasýnda ki uzaklýðý buluyor.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _offset + _targetPos.position, _smoothedSpeed);
        // Lerp için Kendi Poz , baþlangýçta uzaklýðý ile anlýk uzaklýðýný topluyor hedef poz ile , hýz ile yumuþatýyor
        this.transform.position = newPos;
        // kendi transformuna newPosu atýyoruz
    }
}
