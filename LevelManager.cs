using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deathScreen;
    public GameObject healthBar;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    public int score;

    public SaveData data;

    
    public AudioSource GameMusic;
    public AudioSource DeathMusic;



    private void Awake()
    {
        manager = this;
        SaveSystem.Initialize();

        data = new SaveData(0);
    }

    public void GameOver()
    {
        healthBar.SetActive(false);
        deathScreen.SetActive(true);
        Cursor.visible = true;
        scoreText.text = "Score: " + score.ToString();

        string loadedData = SaveSystem.Load("save");
   
        if (loadedData != null)
        {
            data = JsonUtility.FromJson<SaveData>(loadedData);
        }

        if (data.highscore < score)
        {
            data.highscore = score;
        }

        highscoreText.text = "Highscore: " + data.highscore.ToString();

        string saveData = JsonUtility.ToJson(data);
        SaveSystem.Save("save", saveData);
    }

    public void replayLogic()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOverSound()
    {
        GameMusic.Stop();
        DeathMusic.Play();
    }
}

[System.Serializable]
public class SaveData
{
    public int highscore;

    public SaveData(int _hs)
    {
        highscore = _hs;
    }
}
