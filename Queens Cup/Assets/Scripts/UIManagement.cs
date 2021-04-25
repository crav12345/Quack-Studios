using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    #region Variables
    public static UIManagement instance;
    private string sceneName;
    [SerializeField] private GameObject endGameMenu;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Loads scene based on name
    /// </summary>
    /// <param name="sceneName"></param>
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Quits game
    /// </summary>
    public void quitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }

    /// <summary>
    /// Game over
    /// </summary>
    public void GameOver()
    {
        endGameMenu.SetActive(true);
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
