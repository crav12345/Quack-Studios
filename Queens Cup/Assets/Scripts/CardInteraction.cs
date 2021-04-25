using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardInteraction : MonoBehaviour, IPointerClickHandler
{
    #region Variables
    [SerializeField] private GameObject overlay;
    [SerializeField] private Image myImage;
    [SerializeField] private Text myText;
    [SerializeField] public string myValue;
    [SerializeField] public string myRule;
    [SerializeField] public string mySuit;

    [SerializeField] private AudioClip queenSong;
    [SerializeField] private AudioClip cardFlip;
    private AudioSource myAudio;

    private string path = "CardArt/";
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GameObject.Find("Audio").GetComponent<AudioSource>();

        // for the Pointer event
        addPhysics2DRaycaster();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = GameObject.FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        myText.text = myRule;
        myImage.sprite =
            Resources.Load<Sprite>(
                path +
                myValue +
                mySuit
            );

        if(myValue == "Q")
        {
            myAudio.clip = queenSong;
            myAudio.Play();
        }

        overlay.SetActive(true);
    }

    /// <summary>
    /// Destroys card on click
    /// </summary>
    public void destroyCard()
    {
        myAudio.clip = cardFlip;
        myAudio.Play();

        Destroy(gameObject);
    }
}
