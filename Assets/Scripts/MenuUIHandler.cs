using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = DataManager.Instance.Score < 1
            ? "No score registered yet"
            : $"Best score : {DataManager.Instance.BestPlayerName} {DataManager.Instance.Score}";
    }

    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }

    public void SetPlayerName()
    {
        DataManager.Instance.PlayerName = nameInput.text;
    }
}
