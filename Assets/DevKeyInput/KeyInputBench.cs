using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputBench : MonoBehaviour
{
    KeyInput keyInput = new KeyInput();

    void Update()
    {
        keyInput.Update();
    }

    private void FixedUpdate()
    {
        Debug.Log($"{keyInput.GetValue()}");
    }
}
