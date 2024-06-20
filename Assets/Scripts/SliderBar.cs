using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.Damaged += ChangeDisplay;
        _health.Healed += ChangeDisplay;
    }

    private void OnDisable()
    {
        _health.Damaged += ChangeDisplay;
        _health.Healed -= ChangeDisplay;
    }

    private void ChangeDisplay()
    {
        _slider.value = _health.CurrentHealth;
    }
}