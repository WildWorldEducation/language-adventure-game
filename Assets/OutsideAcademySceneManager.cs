using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OutsideAcademySceneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _helloCard;

    [SerializeField]
    private GameObject _doorCard;

    [SerializeField]
    private GameObject _hiCard;
    void Start()
    {
        _helloCard.SetActive(false);
        _doorCard.SetActive(false);
        _hiCard.SetActive(false);
    }



}
