/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

[System.Serializable]
public class HandTrackingGrabber : OVRGrabber
{
    private  Hand hand;
    public float pinchTreshold = 0.7f;

    protected override void Start()
    {
        base.Start();
        hand = GetComponent.<Hand> ();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckIndecPinch();
    }

    void CheckIndexPinch()
    {
        float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchTreshold;

        if (!m_grabbedObj && isPinching && m_granCandidates.Count > 0)
            GrabBegin();
        else if (m_grabbedObj && !isPinching)
            GrabEnd();
    }
}
*/
