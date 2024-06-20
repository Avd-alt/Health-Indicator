using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderBarSmooth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private float _changeSpeed = 15f;
    private Coroutine _coroutineChange;

    private void OnEnable()
    {
        _health.Damaged += StartChange;
        _health.Healed += StartChange;
    }

    private void OnDisable()
    {
        _health.Damaged -= StartChange;
        _health.Healed -= StartChange;
    }

    private void StartChange()
    {
        if(_coroutineChange != null)
        {
            StopCoroutine(_coroutineChange);
        }

        _coroutineChange = StartCoroutine(ChangingDisplay());
    }

    private IEnumerator ChangingDisplay()
    {
        while(_slider.value != _health.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentHealth, _changeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}