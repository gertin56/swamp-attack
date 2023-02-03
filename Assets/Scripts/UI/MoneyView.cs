using TMPro;
using UnityEngine;

public class MoneyView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    

    private void OnEnable()
    {
        _text.text = _player.Money.ToString();
        _player.MoneyChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnValueChanged;
    }

    public void OnValueChanged()
    {
        _text.text = _player.Money.ToString();
    }
}
