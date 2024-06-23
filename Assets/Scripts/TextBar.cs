using TMPro;
using UnityEngine;

public class TextBar : Bar
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        _textMeshPro.text = _health.CurrentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }

    public override void ChangeDisplay()
    {
        _textMeshPro.text = _health.CurrentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }
}