using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardInteraction : MonoBehaviour, IPointerClickHandler
{
    #region Variables
    [SerializeField]private GameObject overlay;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
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
        overlay.SetActive(true);
    }
}
