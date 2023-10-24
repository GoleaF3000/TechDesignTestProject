using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_click_manager : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audio;

    private void OnMouseDown()
    {
        _animator.SetTrigger(Constants.Animation.Mouse_click);
        _audio.Play();
    }
}