using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover
{
    private readonly ITankMoveModel moveModel;

    public TankMover(ITankMoveModel moveModel)
    {
        this.moveModel = moveModel;
    }
}
