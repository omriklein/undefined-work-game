using System;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class SubstringTextMeshPro : MonoBehaviour
{
    public Transform platform;
    //public string fullString = "Your full string goes here";
    public TMP_Text textComponent;

    private void Awake()
    {
        ResetMargins();
    }

    private void ResetMargins()
    {
        float s_x = platform.localScale.x;
        float size = -(s_x / 2 - 0.5f);
        textComponent.margin = new Vector4(size,0,size,0);
    }

    void Start()
    {
        // Get the reference to the TMP_Text component
        textComponent = GetComponent<TMP_Text>();
    }

    public int SetSubStringText(string text)
    {
        textComponent.text = text;
        return textComponent.GetParsedText().Length;
    }
}