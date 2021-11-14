using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPuzzleManager : MonoBehaviour
{
    GameObject fairyObject = null, gingerObject = null, iceObject = null;

    public GameObject FairyObject { get; private set; }
    public GameObject GingerObject { get; private set; }
    public GameObject IceObject { get; private set; }

    public void SetFairyObject(GameObject answer)
    {
        FairyObject = answer;
    }

    public void SetGingerObject(GameObject answer)
    {
        GingerObject = answer;
    }

    public void SetIceObject(GameObject answer)
    {
        IceObject = answer;
    }

    public void DeReferenceFairyObject()
    {
        FairyObject = null;
    }

    public void DeReferenceGingerObject()
    {
        GingerObject = null;
    }

    public void DeReferenceIceObject()
    {
        IceObject = null;
    }
}
