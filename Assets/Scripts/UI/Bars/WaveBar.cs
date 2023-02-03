using UnityEngine;

public class WaveBar : Bar
{
    [SerializeField] private Spawner _spawner;

    private void OnEnable()
    {
        _spawner.SpawnedEnemyCahnged += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spawner.SpawnedEnemyCahnged -= OnValueChanged;
    }
}
