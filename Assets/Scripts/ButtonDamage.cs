using UnityEngine;
using UnityEngine.UI;

public class ButtonDamage : MonoBehaviour
{
    [SerializeField] private Button _buttonHeal;
    [SerializeField] private Health _health;

    private float _damage = 10; 

    private void OnEnable()
    {
        _buttonHeal.onClick.AddListener(Attack);
    }

    private void OnDisable()
    {
        _buttonHeal.onClick.RemoveListener(Attack);
    }

    private void Attack()
    {
        _health.TakeDamage(_damage);
    }
}