using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DialogueReader : MonoBehaviour
{

    //private List<BaseCharacterAsset> CharacterAssests = new List<BaseCharacterAsset>();

    public TextAsset Dialogue;

    private int currentLine; //Line in text file
    private int currentChar; //current Character in the line

    private int lineLimit = 10; //# of characters in a textbox line before moving to the next line

    void LoadResources()
    {
        //CharacterAssests.Clear();
        //BaseCharacterAsset[] resources = Resources.LoadAll<BaseCharacterAsset>(@"CharacterDialogueAssets");
        //foreach (BaseCharacterAsset characterAsset in resources)
        //{
        //        CharacterAssests.Add(characterAsset);
        //}
    }

    private string[] allLines;//array of each line in the text file

    private int lineLength;//length of the current line

    void ReadLine()
    {
        //Debug.Log("Hello?");
        if (currentChar == lineLength)
        {
            //Debug.Log("Hello?");
            NextLine();
        }
        //Debug.Log("Hello?");
        Debug.Log(lineLength);
        Debug.Log(currentChar);
        if (currentChar + lineLimit >= lineLength) { rawSubstring = allLines[currentLine].Substring(currentChar, currentChar + lineLimit); currentChar = lineLength; }
        else { rawSubstring = allLines[currentLine].Substring(currentChar, currentChar + lineLimit); currentChar += lineLimit; }
        FormatSubString();

        Debug.Log(formattedSubString);
    }

    string rawSubstring;//before formatting
    string formattedSubString;//after formatting
    void FormatSubString()
    {
        if (rawSubstring.StartsWith(" "))
        {
            rawSubstring.Remove(0);
        }

        formattedSubString = rawSubstring;
    }

    void NextLine()
    {

        currentChar = 0;
        if (allLines[currentLine + 1] != "")
        {
            Debug.Log("Passes");
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
        lineLength = allLines[currentLine].Length;
    }

    void CompileLines()
    {
        currentLine = 0;
        currentChar = 0;

        allLines = File.ReadAllLines(Dialogue.name.ToString() + ".txt"); //Still Trying to figure this part out. put file in first level of project folder
        for (int i = 0; i < allLines.Length; i++)
        { Debug.Log(allLines[i]); }

        lineLength = allLines[currentLine].Length;
    }

    void EndDialogue()
    {
        Debug.Log("End");
    }
    private void Start()
    {
        CompileLines();
    }

    public void Next()
    {
        ReadLine();
    }
}

