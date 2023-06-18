using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public Transform _playerTransform { get; set; }
    public bool _isGrown { get; set; } = false;
    public bool _isFallen { get; set; } = false;
    public float _timer { get; private set; } = 0;

    private BaseState baseState;
    public GrowState growState = new GrowState();
    public RotateState rotateState = new RotateState();
    public FallState fallState = new FallState();
    public RiseState riseState = new RiseState();

    void Start()
    {
        _playerTransform = GetComponent<Transform>();
        baseState = growState;
        baseState.EnterState(this);
    }

    void Update()
    {
        _timer += Time.deltaTime;
        baseState.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
        _timer = 0;
        baseState = state;
        baseState.EnterState(this);
    }

    public void DestroyRb()
    {
        if (TryGetComponent(out Rigidbody rigidbody))
        {
            Destroy(rigidbody);
        }
    }
}
