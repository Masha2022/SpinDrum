using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDrum : MonoBehaviour
{
    public void StopButton()
    {
        GetComponent<HingeJoint>().useMotor = false;
    }
}