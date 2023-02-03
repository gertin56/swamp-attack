using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Button _sellButton;

    private Weapon _weapon;

    public event UnityAction<Weapon, WeaponView> SellButtonClick;

    private void OnEnable()
    {
        _sellButton.onClick.AddListener(OnSellButtonClick);
        _sellButton.onClick.AddListener(TryLockButton);
    }

    private void OnDisable()
    {
        _sellButton.onClick.RemoveListener(OnSellButtonClick);
        _sellButton.onClick.RemoveListener(TryLockButton);
    }

    public void Render(Weapon weapon)
    {
        _weapon = weapon;

        _label.text = weapon.Lable;
        _icon.sprite = weapon.Sprite;
        _price.text = weapon.Price.ToString();
    }

    private void TryLockButton()
    {
        if (_weapon.IsBuyed)
        {
            _sellButton.interactable = false;
            _sellButton.GetComponent<Image>().color = Color.green;
        }
    }

    public void OnSellButtonClick()
    {
        SellButtonClick?.Invoke(_weapon, this);
    }
}
