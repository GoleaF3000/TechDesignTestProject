using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Mouse_click_manager))]
public class UI_button_activator : MonoBehaviour
{
    [SerializeField] private Button _scene_change_button;

    private Mouse_click_manager _mouse_manager;

    private void Awake()
    {
        _mouse_manager = GetComponent<Mouse_click_manager>();
    }

    private void OnEnable()
    {
        _mouse_manager.Mouse_cliked += OnTurnOnButtonUI;
    }

    private void OnDisable()
    {
        _mouse_manager.Mouse_cliked -= OnTurnOnButtonUI;
    }

    private void OnTurnOnButtonUI()
    {        
        if (_scene_change_button.gameObject.active == false)
        {
            _scene_change_button.gameObject.active = true;
        }
    }
}