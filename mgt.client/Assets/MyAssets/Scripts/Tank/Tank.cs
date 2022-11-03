using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using IceMilkTea.Core;
using Fusion;

public partial class Tank : NetworkBehaviour
{
    private enum StateEventId
    {
        Acceleration,
        Deceleration,
        Stop,
    }

    [SerializeField]
    private TankModel model = default;

    private TankMover mover;

    private ImtStateMachine<Tank> stateMachine;

    private readonly MessageBroker messageBroker = new MessageBroker();

    private void Awake()
    {
        mover = new TankMover(model);
        stateMachine = new ImtStateMachine<Tank>(this);

        stateMachine.AddTransition<IdolState, AccelerationState>((int)StateEventId.Acceleration);
        stateMachine.AddTransition<AccelerationState, DecelerationState>((int)StateEventId.Deceleration);
        stateMachine.AddTransition<DecelerationState, AccelerationState>((int)StateEventId.Acceleration);
        stateMachine.AddTransition<DecelerationState, IdolState>((int)StateEventId.Stop);
        stateMachine.AddTransition<AccelerationState, IdolState>((int)StateEventId.Stop);
        stateMachine.SetStartState<IdolState>();
    }
}
