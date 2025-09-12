using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public List<GameObject> lsUIs = new List<GameObject>();
    public int currentIndexUI;

    public GameObject goCharacter;
    public SpawnManager spawnManager;
    public TestPhysics testPhysics;

    public List<GameObject> lsGoLives = new List<GameObject>();

    public List<TextMeshProUGUI> lsTxtScores = new List<TextMeshProUGUI>();
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtBestScore;


    // Start is called before the first frame update
    void Start()
    {
        currentIndexUI = 0;
        goCharacter.SetActive(false);
        for (int i = 0; i < lsUIs.Count; i++)
        {
            if (i == currentIndexUI)
            {
                lsUIs[i].SetActive(true);
            }
            else
            {
                lsUIs[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartGameClicked()
    {
        lsUIs[currentIndexUI].SetActive(false);

        currentIndexUI = 1;
        lsUIs[currentIndexUI].SetActive(true);

        // Start game
        goCharacter.SetActive(true);
        spawnManager.isStartGame = true;

        testPhysics.scores = 0;
        UpdateScore(testPhysics.scores);

        testPhysics.lives = 3;
        UpdateLives(testPhysics.lives);
    }


    public void ShowGameOver()
    {
        lsUIs[currentIndexUI].SetActive(false);

        currentIndexUI = 2;
        lsUIs[currentIndexUI].SetActive(true);

        goCharacter.SetActive(false);
        spawnManager.isStartGame = false;
    }

    public void OnRestartGameClick()
    {
        lsUIs[currentIndexUI].SetActive(false);

        currentIndexUI = 0;
        lsUIs[currentIndexUI].SetActive(true);
    }

    public void UpdateLives(int lives)
    {
        for(int i = 0; i < lsGoLives.Count; i++)
        {
            if (i < lives)
            {
                lsGoLives[i].SetActive(true);
            }
            else
            {
                lsGoLives[i].SetActive(false);
            }
        }
    }

    public void UpdateScore(int score)
    {
        for (int i = 0; i < lsTxtScores.Count; i++)
        {
            lsTxtScores[i].text = score.ToString();
        }
        txtScore.text = score.ToString();

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        if (bestScore < score)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        txtBestScore.text = bestScore.ToString();
    }
}
