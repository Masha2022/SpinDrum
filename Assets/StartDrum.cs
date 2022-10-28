using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartDrum : MonoBehaviour
{
    private JointMotor _Motor;

    public void StartButton()
    {
        GetComponent<HingeJoint>().useMotor = true;
        _Motor.force = 200;
        _Motor.targetVelocity = 100;
        GetComponent<HingeJoint>().motor = _Motor;
    }
}