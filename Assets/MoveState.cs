using UnityEngine;

public class MoveState : IState
{
    public void OnEnter()
    {
        Debug.Log("Move state entered");
    }

    public void OnExit()
    {
        Debug.Log("Move state exited");
    }

    public void OnUpdate()
    {
 
    }
}
