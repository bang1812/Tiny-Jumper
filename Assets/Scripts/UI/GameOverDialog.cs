using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverDialog : Dialog
{
    public Text bestScoreText;
    bool m_replayBtnClicked;

    private void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public override void Show(bool isShow)
    {
        base.Show(isShow);

        
        if(Prefs.hasNewBest == true){
            if(bestScoreText){
                bestScoreText.text = Prefs.bestScore.ToString();
            }
        }
        else{
            if(bestScoreText){
                bestScoreText.text = GameManager.Ins.YourScore().ToString();
            }
        }
    }

    public void Replay(){
        m_replayBtnClicked = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToHome(){
        GameGUIManager.Ins.ShowGameGUI(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        if(m_replayBtnClicked){
            GameManager.Ins.PlayGame();
        }

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
