using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PlatformsTextManager : MonoBehaviour
{
    private string codeText = "";
    private SubstringTextMeshPro[] platfomrsTexts; 
    private bool initializes = false;
    private PlatformsTextManager textManager;
    
    private void Start()
    {
        textManager = this;
        platfomrsTexts = FindObjectsOfType<SubstringTextMeshPro>();
        
        string h = GetStringFromFile.GetTextFromResources();
        codeText = h == "" ? codeText : h;
    }

    private int i;
    private string subString;

    private void Update()
    {
        i = 0;
        subString = codeText;
        foreach (SubstringTextMeshPro scripts in platfomrsTexts)
        {
            i += scripts.SetSubStringText(subString);
            subString = i < codeText.Length - 1 ? codeText.Substring(Mathf.Max(i - 1, 0)) : "";
        }

        if (i != 0)
        {
            Debug.Log("Loaded all platforms texts");
            textManager.enabled = false;
        }
    }
}
