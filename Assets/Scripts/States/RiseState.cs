using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseState : BaseState
{
    private Vector3 pos = new Vector3(0, .5f, 0);

    public override void EnterState(StateManager state)
    {
        Debug.Log("Hello from RiseState");
        state.DestroyRb();
    }

    public override void UpdateState(StateManager state)
    {
        if (state._timer >= 5)
            state.SwitchState(state.growState);
        else
            state._playerTransform.position += pos * Time.deltaTime;
    }
}
