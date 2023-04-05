using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private StateMachine _playerStateMachine;
    private MoveState _moveState;
    private IdleState _idleState;

    public static Action<IState> OnPlayerStateChanged;

    private void Awake()
    {
        _playerStateMachine = new StateMachine();
        _moveState = new MoveState();
        _idleState = new IdleState();

        
    }
    // Start is called before the first frame update
    void Start()
    {
        _playerStateMachine.OnStateChanged += (state) => OnPlayerStateChanged?.Invoke(state);

        _playerStateMachine.AddTransition(_moveState, _idleState, IsMoving);
        _playerStateMachine.AddTransition(_idleState, _moveState, IsNotMoving);

        _playerStateMachine.Init(_idleState);
    }

    // Update is called once per frame
    void Update()
    {
        _playerStateMachine.Tick();
    }

    public bool IsMoving()
    {
        return GetComponent<PlayerMovementInputController>()._move != Vector2.zero;
    }
    public bool IsNotMoving()
    {
        return GetComponent<PlayerMovementInputController>()._move == Vector2.zero;
    }

    private void OnDisable()
    {
        _playerStateMachine.OnStateChanged -= (state) => OnPlayerStateChanged?.Invoke(state);
    }
}
