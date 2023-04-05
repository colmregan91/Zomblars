using UnityEngine;

public class IdleState : IState
{
    public void OnEnter()
    {
        Debug.Log("Idle state entered");
    }

    public void OnExit()
    {
        Debug.Log("Idle state exited");
    }

    public void OnUpdate()
    {

    }
}
