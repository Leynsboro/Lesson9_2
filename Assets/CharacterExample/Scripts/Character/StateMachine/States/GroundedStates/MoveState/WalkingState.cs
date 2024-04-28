public class WalkingState : MoveState
{
    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.WalkingSpeed;

        View.StartWalking();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopWalking();
    }

    public override void Update()
    {
        base.Update();

        if (IsWalingInput())
            return;


        StateSwitcher.SwitchState<RunningState>();
    }
}
