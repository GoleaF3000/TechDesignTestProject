using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_launch_manager : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnMouseDown()
    {
        _animator.SetTrigger(Constants.Animation.Mouse_click);
    }
}