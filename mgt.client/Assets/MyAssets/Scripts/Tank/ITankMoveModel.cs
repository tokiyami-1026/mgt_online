using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public interface ITankMoveModel
{
    public float MaxSpeed { get; }

    public float Acceleration { get; }

    public float Deceleration { get; }
}
