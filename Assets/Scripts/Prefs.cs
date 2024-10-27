using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Prefs
{
    public static bool hasNewBest;

    public static int bestScore{
        set{
            if(PlayerPrefs.GetInt(PrefConsts.BEST_SCORE, 0) < value){
                hasNewBest = true;
                PlayerPrefs.SetInt(PrefConsts.BEST_SCORE, value);
            }
            else{
                hasNewBest = false;
            }
        }

        get => PlayerPrefs.GetInt(PrefConsts.BEST_SCORE, 0);
    }
}
