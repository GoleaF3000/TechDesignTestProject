using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mouse_click_manager : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audio;

    public event UnityAction Mouse_cliked;

    private void OnMouseDown()
    {
        if (_audio != null)
        {
            _audio.Play();
        }

        _animator.SetTrigger(Constants.Animation.Mouse_click);
        Mouse_cliked?.Invoke();
    }
}