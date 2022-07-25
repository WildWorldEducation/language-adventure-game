using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairyDialogue : MonoBehaviour
{
    [SerializeField]
    private Image _fairyDialoguePanel;
   
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        _fairyDialoguePanel.GetComponent<CanvasGroup>().alpha = 1;
        _fairyDialoguePanel.GetComponent<CanvasGroup>().interactable = true;        
    }

    public void CloseDialoguePanel()
    {
        _fairyDialoguePanel.GetComponent<CanvasGroup>().alpha = 0;
        _fairyDialoguePanel.GetComponent<CanvasGroup>().interactable = false;
    }
}
