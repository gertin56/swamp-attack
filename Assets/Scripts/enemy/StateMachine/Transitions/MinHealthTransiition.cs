using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class MinHealthTransiition : Transition
{
    [SerializeField] private int _minHealth;

    private Enemy _target;

    private void OnEnable()
    {
        _target = GetComponent<Enemy>();
    }

    private void Update()
    {
        if(_target.Health <= _minHealth)
        {
            NeedTransit = true;
        }
    }
}
