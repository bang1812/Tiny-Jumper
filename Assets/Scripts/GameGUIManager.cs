using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGUIManager : Singleton<GameGUIManager>
{
    public GameObject homeGUI;
    public GameObject gameGUI;
    public Text scoreCountingText;
    public Image powerBarSlider;

    public Dialog achivementDialog;
    public Dialog helpDialog;
    public Dialog gameoverDialog;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    public void ShowGameGUI(bool isShow){
        if(gameGUI){
            gameGUI.SetActive(isShow);
        }

        if(homeGUI){
            homeGUI.SetActive(!isShow);
        }
    }

    public void UpdateScoreCounting(int score){
        if(scoreCountingText){
            scoreCountingText.text = score.ToString();
        }
    }

    public void UpdatePowerBar(float curVal, float totalVal){
        if(powerBarSlider){
            powerBarSlider.fillAmount = curVal / totalVal;
        }
    }

    public void ShowAchivementDialog(){
        if(achivementDialog){
            achivementDialog.Show(true);
        }
    }

    public void ShowHelpDialog(){
        if(helpDialog){
            helpDialog.Show(true);
        }
    }

    public void ShowGameoverDialog(){
        if(gameoverDialog){
            gameoverDialog.Show(true);
        }
    }
}
