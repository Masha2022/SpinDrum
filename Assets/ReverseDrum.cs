using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ReverseDrum : MonoBehaviour
{
    private JointMotor _Motor;
    public void ReverseButton()
    {
        GetComponent<HingeJoint>().useMotor = true;
        _Motor = new JointMotor();
        _Motor.force = 200;
        _Motor.targetVelocity = -100;
        GetComponent<HingeJoint>().motor = _Motor;
    }
}
