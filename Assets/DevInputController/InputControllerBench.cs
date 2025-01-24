using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControllerBench : MonoBehaviour
{
    InputController inputController = new();

    private void Update()
    {
        inputController.Update();
    }

    private void FixedUpdate()
    {
        var move = inputController.GetValue();
        Debug.Log($"{move}");
    }
}
