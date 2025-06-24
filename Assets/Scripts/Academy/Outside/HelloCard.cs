using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCard : MonoBehaviour
{
    [SerializeField]
    private SpellBook _spellBook;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.hello = true;
       // SpellBookUI.Hello();

        _spellBook.HelloSpell.GetComponent<CanvasGroup>().alpha = 1;
    }
}
