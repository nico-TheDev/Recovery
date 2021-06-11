using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI chapterText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        chapterText.SetText(dialogue.chapter);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        string targetText = "";
        foreach (char letter in sentence.ToCharArray())
        {
            targetText += letter;
            dialogueText.SetText(targetText);
            yield return null;
        }
    }

    void EndDialogue()
    {
        print("Chapter End");
    }
}
