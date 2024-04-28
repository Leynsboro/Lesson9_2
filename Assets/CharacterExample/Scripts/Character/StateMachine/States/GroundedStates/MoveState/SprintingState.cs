public class SprintingState : MoveState
{

    public SprintingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.SpringtingSpeed;

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

        if (IsSprintingInput())
            return;

        StateSwitcher.SwitchState<RunningState>();
    }


}
