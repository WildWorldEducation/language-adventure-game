using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlocks : MonoBehaviour
{
    GameObject CAT, DOG, OWL, BEAR, MONKEY, HELLO, RED, YELLOW, BLUE, GREEN, DOOR, MAY, EVA;
    private bool book;

    void Start()
    {
        book = true;

        CAT = GameObject.Find("CAT");
        DOG = GameObject.Find("DOG");
        OWL = GameObject.Find("OWL");
        BEAR = GameObject.Find("BEAR");
        MONKEY = GameObject.Find("MONKEY");
        HELLO = GameObject.Find("HELLO");
        DOOR = GameObject.Find("DOOR");
        MAY = GameObject.Find("MAY");
        EVA = GameObject.Find("EVA");
        RED = GameObject.Find("RED");
        BLUE = GameObject.Find("BLUE");
        GREEN = GameObject.Find("GREEN");
        YELLOW = GameObject.Find("YELLOW");

        if (!Progress.cat)
            CAT.SetActive(false);

        if (!Progress.dog)
            DOG.SetActive(false);

        if (!Progress.bear)
            BEAR.SetActive(false);

        if (!Progress.monkey)
            MONKEY.SetActive(false);

        if (!Progress.owl)
            OWL.SetActive(false);

        if (!Progress.door)
            DOOR.SetActive(false);

        if (!Progress.red)
            RED.SetActive(false);

        if (!Progress.blue)
            BLUE.SetActive(false);

        if (!Progress.green)
            GREEN.SetActive(false);

        if (!Progress.yellow)
            YELLOW.SetActive(false);

        if (!Progress.hello)
            HELLO.SetActive(false);

        if (!Progress.may)
            MAY.SetActive(false);

        if (!Progress.eva)
            EVA.SetActive(false);


    }

    private void OnMouseDown()
    {
        if (book)
        {
            book = false;

            // if (TestExerciseNext.catFlag)
            // {
            //     CAT.SetActive(false);
            // }

            // if (TestExerciseNext.dogFlag)
            // {
            //     DOG.SetActive(false);
            // }

            // if (TestExerciseNext.owlFlag)
            // {
            //     OWL.SetActive(false);
            // }

            // if (TestExerciseNext.bearFlag || Progress.bear)
            // {
            //     BEAR.SetActive(false);
            // }


            MONKEY.SetActive(false);
            DOOR.SetActive(false);
            RED.SetActive(false);
            BLUE.SetActive(false);
            GREEN.SetActive(false);
            YELLOW.SetActive(false);
            HELLO.SetActive(false);
            MAY.SetActive(false);
            EVA.SetActive(false);
        }
        else
        {
            book = true;

            if (Progress.monkey)
                MONKEY.SetActive(true);

            if (Progress.door)
                DOOR.SetActive(true);

            if (Progress.red)
                RED.SetActive(true);

            if (Progress.blue)
                BLUE.SetActive(true);

            if (Progress.green)
                GREEN.SetActive(true);

            if (Progress.yellow)
                YELLOW.SetActive(true);

            if (Progress.hello)
                HELLO.SetActive(true);

            if (Progress.may)
                MAY.SetActive(true);

            if (Progress.eva)
                EVA.SetActive(true);

        }
    }
}
