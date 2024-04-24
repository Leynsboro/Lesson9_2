using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintingState : GroundedState
{
    private readonly GroundedStateConfig _config;

    public SprintingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.GroundedStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.SpringtingSpeed;

        View.StartSprinting();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopSprinting();
    }

    public override void Update()
    {
        base.Update();

        if (IsSpringtingInput() == false)
            StateSwitcher.SwitchState<RunningState>();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }


}
