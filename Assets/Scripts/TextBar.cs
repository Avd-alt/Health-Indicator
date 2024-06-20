using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Health _health;

    private void Start()
    {
        _textMeshPro.text = _health.CurrentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }

    private void OnEnable()
    {
        _health.Damaged += DisplayText;
        _health.Healed += DisplayText;
    }

    private void OnDisable()
    {
        _health.Damaged -= DisplayText;
        _health.Healed -= DisplayText;
    }

    private void DisplayText()
    {
        _textMeshPro.text = _health.CurrentHealth.ToString() + "/" + _health.MaxHealth.ToString();
    }
}