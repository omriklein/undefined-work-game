using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGlobalScale : MonoBehaviour
{
    void Awake()
    {
        Transform parent = transform.parent;
        this.transform.SetParent(null);
        this.transform.localScale = Vector3.one;
        this.transform.SetParent(parent);
        this.transform.localPosition = Vector3.zero;
    }
}
