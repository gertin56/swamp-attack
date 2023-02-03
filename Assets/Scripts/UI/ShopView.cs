using UnityEngine;


public class ShopView : MonoBehaviour
{
    [SerializeField] private Shop _shop;
    [SerializeField] private WeaponView _template;
    [SerializeField] private GameObject _container;

    private void Start()
    {
        Render(_shop);
    }

    private void Render(Shop shop)
    {
        for(int i = 0; i < shop.WeaponsCount; i++)
        {
            AddItem(shop.GetWeapon(i));
        }
    }

    private void AddItem(Weapon weapon)
    {
        var view = Instantiate(_template, _container.transform);
        view.Render(weapon);
        view.SellButtonClick += OnSellButtonClick;
    }

    public void OnSellButtonClick(Weapon weapon, WeaponView view)
    {
        if (_shop.TrySellWeapon(weapon))
        {
            view.SellButtonClick -= OnSellButtonClick;
        }
    }
}
