using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairyDialogue : MonoBehaviour
{
    [SerializeField]
    private Image _dialoguePanel;
    [SerializeField]
    private Text _dialogueText;
    [SerializeField]
    private GameObject _helloCard;
    [SerializeField]
    private GameObject _doorCard;


    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        _dialoguePanel.GetComponent<CanvasGroup>().alpha = 1;
        _dialoguePanel.GetComponent<CanvasGroup>().interactable = true;        
    }

    public void DisplayDialogue(string dialogue)
    {
        _dialogueText.text = "Nice to meet you!";
        _dialoguePanel.GetComponent<CanvasGroup>().alpha = 1;
        _dialoguePanel.GetComponent<CanvasGroup>().interactable = true;
    }

    public void CloseDialoguePanel()
    {
        if (!Progress.hello)
        {
            _dialoguePanel.GetComponent<CanvasGroup>().alpha = 0;
            _dialoguePanel.GetComponent<CanvasGroup>().interactable = false;

            _helloCard.SetActive(true);
        }
        else if (!Progress.door)
        {
            Hello_UI.fairyLocked = false;
            Hello_UI.ReturnToInitialPosition();

            _dialogueText.text = "Go through that door.";
            _doorCard.SetActive(true);
        }
        else
        {
            _dialoguePanel.GetComponent<CanvasGroup>().alpha = 0;
            _dialoguePanel.GetComponent<CanvasGroup>().interactable = false;
        }
    }
}
