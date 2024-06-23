using UnityEngine;
using UnityEngine.UI;

public class ButtonHeal : MonoBehaviour
{
    [SerializeField] private Button _buttonDamage;
    [SerializeField] private Health _health;

    private float _healthRestore = 10;

    private void OnEnable()
    {
        _buttonDamage.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _buttonDamage.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _health.Heal(_healthRestore);
    }
}