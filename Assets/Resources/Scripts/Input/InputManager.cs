﻿using UnityEngine;
using System.Collections;
using System;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputAxisState[] _inputs; //Array of inputs recieved from Input.GetAxis and stored for processing

    [SerializeField]
    private InputState _inputState; //The input state that is to be managed

    private void Update()
    {
        foreach (var input in this._inputs)
        {
            this._inputState.SetButtonValue(input.Button, input.IsPressed, input.Value); //This updates all of the states of the button presses
        }
    }
}