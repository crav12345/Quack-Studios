using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    #region Variables
    private string sceneName;
    //private AudioSource myAudio;
    //[SerializeField] private AudioClip cardFlip;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //myAudio = GameObject.Find("Audio").GetComponent<AudioSource>();
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

    ///// <summary>
    ///// Destroys card on click
    ///// </summary>
    //public void destroyCard()
    //{
    //    myAudio.clip = cardFlip;
    //    myAudio.Play();

    //    Destroy(gameObject);
    //}
}
