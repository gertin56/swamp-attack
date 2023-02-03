using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private List<Weapon> _wapons;

    public int WeaponsCount => _wapons.Count;

    public Weapon GetWeapon(int index)
    {
        return _wapons[index];
    }

    public bool TrySellWeapon(Weapon weapon)
    {
        if(_player.Money >= weapon.Price)
        {
            _player.BuyWeapon(weapon);
            weapon.Buy();
            return true;
        }
        else
        {
            return false;
        }
    }

}
