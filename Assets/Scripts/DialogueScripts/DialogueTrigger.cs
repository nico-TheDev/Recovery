using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue chapterZero;

    public Dialogue chapterOne;
    public Dialogue chapterTwo;
    public Dialogue chapterThree;
    public Dialogue chapterFour;
    public Dialogue chapterFive;
    public Dialogue chapterSix;
    public Dialogue chapterSeven;
    public Dialogue chapterEight;
    public Dialogue chapterNine;
    public Dialogue chapterTen;

    DialogueManager dialogueManager;

    int currentChapter;

    void Awake()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        currentChapter = PlayerPrefs.GetInt("CurrentPlayerLevel");
        FindObjectOfType<AudioManager>().Play("dialogue");

    }
    void Start()
    {
        switch (currentChapter)
        {
            case 0:
                dialogueManager.StartDialogue(chapterZero);
                break;
            case 1:
                dialogueManager.StartDialogue(chapterOne);
                break;
            case 2:
                dialogueManager.StartDialogue(chapterTwo);
                break;
            case 3:
                dialogueManager.StartDialogue(chapterThree);
                break;
            case 4:
                dialogueManager.StartDialogue(chapterFour);
                break;
            case 5:
                dialogueManager.StartDialogue(chapterFive);
                break;
            case 6:
                dialogueManager.StartDialogue(chapterSix);
                break;
            case 7:
                dialogueManager.StartDialogue(chapterSeven);
                break;
            case 8:
                dialogueManager.StartDialogue(chapterEight);
                break;
            case 9:
                dialogueManager.StartDialogue(chapterNine);
                break;
            case 10:
                dialogueManager.StartDialogue(chapterTen);
                break;

        }

    }

    // public void TriggerDialogue()
    // {
    //     dialogueManager.StartDialogue(dialogue);
    // }

    // public void StartTargetDialogue() { }

}
