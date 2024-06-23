using UnityEngine;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Health _health;

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

    public abstract void ChangeDisplay();
}