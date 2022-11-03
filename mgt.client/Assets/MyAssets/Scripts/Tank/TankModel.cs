using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankModel", menuName = "ScriptableObjects/TankModel")]
public class TankModel : ScriptableObject, ITankMoveModel
{
    [Header("ˆÚ“®") ,SerializeField]
    private float maxSpeed = 30;
    public float MaxSpeed => maxSpeed;

    [SerializeField]
    private float acceleration = 0.03f;
    public float Acceleration => acceleration;

    [SerializeField]
    private float deceleration = 0.05f;
    public float Deceleration => deceleration;
}
