using UnityEngine;

public class GrowState : BaseState
{
    private Vector3 scale = new Vector3(0.2f, .1f, .1f);

    public override void EnterState(StateManager state)
    {
        Debug.Log("Hello from the grow state");
    }

    public override void UpdateState(StateManager state)
    {
        if (state._timer >= 5)
        {
            state._isGrown = !state._isGrown;
            state.SwitchState(state.rotateState);
        }
        else
            state._playerTransform.localScale += ChangeSize(state) * Time.deltaTime;
    }

    private Vector3 ChangeSize(StateManager state)
    {
        if (state._isGrown)
            return -scale;
        else
            return scale;
    }
}
