using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBehaviour : MonoBehaviour
{
    private int roundCount;
    private int good_AdClickedCount;
    private int bad_AdClickedCount;

    bool start = false;
    public void OnGoodClicked()
    {
        good_AdClickedCount++;
    }
    public void OnBadClicked()
    {
        bad_AdClickedCount++;
    }

    public void GameStart()
    {
        RoundStart();
    }
    public void RoundStart()
    {
        bad_AdClickedCount = 0;
        good_AdClickedCount = 0;
        roundCount = 0;
        start = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
            return;
        if (roundCount > 4)
        {
            GameEnd();
        }
        else
        {
            RoundStart();
        }

        if (bad_AdClickedCount > 3)
        {
            GameStart();
        }//otherwise just loop

        if (good_AdClickedCount > 5)
        {
            RoundEnd();
        }//otherwise just continue
    }


    public void RoundEnd()
    {
        bad_AdClickedCount = 0;
        good_AdClickedCount = 0;
        roundCount++;
    }


    public void GameEnd()
    {
        Debug.Log("end game");
    }



}
