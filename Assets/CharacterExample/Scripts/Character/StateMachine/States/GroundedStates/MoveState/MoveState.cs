using UnityEngine;

public class MoveState : GroundedState
{
    protected GroundedStateConfig Config;

    protected bool IsSprintingInput() => Input.Movement.Sprint.IsPressed();
    protected bool IsWalingInput() => Input.Movement.Walk.IsPressed();

    public MoveState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.GroundedStateConfig;


    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
