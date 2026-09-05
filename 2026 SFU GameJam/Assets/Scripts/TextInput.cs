using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TextInput : MonoBehaviour
{
    private string text;

    string[] booms = { "boom", "bam", "pow" };
    
    string[] slashes = { "slash", "shing" };
    string[] zaps = { "zap" };
    string[] whooshes = { "whoosh", "woosh" };
    string[] thumps = { "thump", "wham", "wam", "slam" };

    public void TextInputCheck(string s)
    {
        text = s;

        bool isBoom = false;
        bool isSlash = false;
        bool isZap = false;
        bool isWhoosh = false;
        bool isThump = false;

        foreach (string boom in booms)
        {
            if (string.Equals(boom, text, StringComparison.OrdinalIgnoreCase))
            {
                isBoom = true;
                break;
            }
        }
        foreach (string slash in slashes)
        {
            if (string.Equals(slash, text, StringComparison.OrdinalIgnoreCase))
            {
                isSlash = true;
                break;
            }
        }
        foreach (string zap in zaps)
        {
            if (string.Equals(zap, text, StringComparison.OrdinalIgnoreCase))
            {
                isZap = true;
                break;
            }
        }
        foreach (string whoosh in whooshes)
        {
            if (string.Equals(whoosh, text, StringComparison.OrdinalIgnoreCase))
            {
                isWhoosh = true;
                break;
            }
        }
        foreach (string thump in thumps)
        {
            if (string.Equals(thump, text, StringComparison.OrdinalIgnoreCase))
            {
                isThump = true;
                break;
            }
        }

        if (isBoom == true)
        {
            Debug.Log("casted BOOM");
        }
        if (isSlash == true)
        {
            Debug.Log("casted SLASH");
        }
        if (isZap == true)
        {
            Debug.Log("casted ZAP");
        }
        if (isWhoosh == true)
        {
            Debug.Log("casted WHOOSH");
        }
        if (isThump == true)
        {
            Debug.Log("casted THUMP");
        }
    }
}