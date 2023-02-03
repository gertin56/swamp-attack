using System;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _lable;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private bool _isBuyed = false;

    [SerializeField] protected Bullet Bullet;

    public string Lable => _lable;
    public int Price => _price;
    public Sprite Sprite => _sprite;
    public bool IsBuyed => _isBuyed;

    public abstract void Shoot(Transform shootPoint);

    internal void Buy()
    {
        _isBuyed = true;
    }
}
