using UnityEngine;

public class RotateState : BaseState
{
    public override void EnterState(StateManager state)
    {
        Debug.Log("Hello from rotateState!");
    }

    public override void UpdateState(StateManager state)
    {
        if (state._timer >= 5)
            state.SwitchState(state.fallState);
        else
            state._playerTransform.Rotate(0, .5f, 0);
    }
}
