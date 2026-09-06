using System;
using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class TextInput : MonoBehaviour
{
    [SerializeField] public TMP_Text myTMP;
    
    private string text;

    public Boolean wordIsCorrect;

    public Boolean isBoom;
    public Boolean isSlash;
    public Boolean isZap;
    public Boolean isWhoosh;
    public Boolean isThump;

    string[] correctWords = { "boom", "bam", "pow", "slash", "shing", "zap", "whoosh", "woosh", "thump", "wham", "wam", "slam"};
    string[] booms = { "boom", "bam", "pow" };
    string[] slashes = { "slash", "shing" };
    string[] zaps = { "zap" };
    string[] whooshes = { "whoosh", "woosh" };
    string[] thumps = { "thump", "wham", "wam", "slam" };

    public void TextInputCheck(string s)
    {
        text = s;

        isBoom = false;
        isSlash = false;
        isZap = false;
        isWhoosh = false;
        isThump = false;

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
    }

    public void CorrectWord(string s)
    {
        text = s;

        foreach (string word in correctWords)
        {
            if(string.Equals(word, text, StringComparison.OrdinalIgnoreCase))
            {
                wordIsCorrect = true;
                SoundManager.Instance.Play(SoundManager.SoundType.Ding);
                ChangeToGreen();
                break;
            }
        }
    }

    public void ChangeToGreen()
    {
        myTMP.color = Color.green;
    }

    public void ChangeToBlack()
    {
        myTMP.color = Color.black;
    }

    public void ResetText()
    {
        myTMP.text = "";
    }
}