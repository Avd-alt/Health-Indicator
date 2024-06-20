using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxHealth { get; private set; } = 100;
    public float MinHealt { get; private set; } = 0;
    public float CurrentHealth { get; private set; }

    public event Action Damaged;
    public event Action Healed;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (damage > 0)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth - damage, MinHealt, MaxHealth);

            Damaged?.Invoke();
        }
    }

    public void Heal(float amountHealthRestore)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + amountHealthRestore, MinHealt, MaxHealth);

        Healed?.Invoke();
    }
}