using UnityEngine;

public class KeyInput : IInput
{
    Vector2 inputValue;

    public Vector2 GetValue()
    {
        return inputValue;
    }

    public void Update()
    {
        inputValue.x = Input.GetAxisRaw("Horizontal");
        inputValue.y = Input.GetAxisRaw("Vertical");
        inputValue = 1.0f * inputValue.normalized;
    }
}
