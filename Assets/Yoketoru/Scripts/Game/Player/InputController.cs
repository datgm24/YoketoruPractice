using UnityEngine;

public class InputController
{
    IInput[] inputs =
    {
        new KeyInput(),
    };

    public void Update()
    {
        for (int i = 0; i < inputs.Length; i++)
        {
            inputs[i].Update();
        }
    }

    public Vector2 GetValue()
    {
        Vector2 value = Vector2.zero;

        for (int i = 0;i<inputs.Length;i++)
        {
            var v = inputs[i].GetValue();
            if (v.magnitude > value.magnitude)
            {
                value = v;
            }
        }

        return value;
    }
}
