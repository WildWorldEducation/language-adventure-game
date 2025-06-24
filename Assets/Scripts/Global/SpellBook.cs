using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBook : MonoBehaviour
{
    [SerializeField]
    private GameObject _spellBook;
        
    public Image HelloSpell;
    
    public static bool CATAttained, DOGAttained;
    public static GameObject bear, monkey, door, hello, may, eva;
    void Start()
    {            
    }

    public void ToggleOpen()
    { 
        if (_spellBook.GetComponent<CanvasGroup>().alpha == 0)
        {
            _spellBook.GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            _spellBook.GetComponent<CanvasGroup>().alpha = 0;
        }        
    }
}
