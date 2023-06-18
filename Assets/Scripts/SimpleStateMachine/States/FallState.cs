using UnityEngine;
using System.Collections.Generic;

public class FallState : BaseState
{
    public override void EnterState(StateManager state)
    {
        Debug.Log("Hello from FallState!");
        state.gameObject.AddComponent<Rigidbody>();
    }

    public override void UpdateState(StateManager state)
    {
        if (state._timer >= 5)
            state.SwitchState(state.riseState);
    }
}
