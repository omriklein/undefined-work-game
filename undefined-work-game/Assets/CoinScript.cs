using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int value = 1;

    private float amp = 0.2f;
    private float freq = 0.7f;
    private Vector3 originPos = new Vector3();
    private Vector3 currPos = new Vector3();

    void Start()
    {
        originPos = transform.position;
    }

    void Update()
    {
        currPos = originPos;
        currPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * freq)* amp;
        transform.position = currPos;
    }
}
