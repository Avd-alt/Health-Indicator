using UnityEngine;
using UnityEngine.UI;

public class SliderBar : Bar
{
    [SerializeField] private Slider _slider;

    public override void ChangeDisplay()
    {
        _slider.value = _health.CurrentHealth;
    }
}