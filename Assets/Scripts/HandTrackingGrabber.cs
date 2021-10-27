using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

[System.Serializable]
public class HandTrackingGrabber : OVRGrabber
{
    private OVRHand hand;
    public float pinchTreshold = 0.7f;

    protected override void Start()
    {
        base.Start();
        hand = GetComponent<OVRHand> ();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }

    void CheckIndexPinchWorking()
    {
        float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchTreshold;

        if (isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
            Debug.Log("Is pinching");
        }

        else if (m_grabbedObj && !isPinching)
            GrabEnd(); 
        Debug.Log("Is NOT pinching");


    }

    void CheckIndexPinch()
    {
        float pinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchTreshold;

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
            Debug.Log("Is pinching");
        }
        else if (m_grabbedObj && !isPinching)            
            GrabEnd();
    }
}

