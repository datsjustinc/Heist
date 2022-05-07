using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Interactable2 : MonoBehaviour
{
    public Sprite iconSprite;
    public Vector3 iconOffset;
    public GameObject testAgentObject;
    private Canvas canvas;
    private RectTransform canvasRect;
    private RectTransform iconRect;
    private GameObject iconObject;
    public GameObject vaultDoor;
    public int open;

    //public bool bank;

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        canvasRect = canvas.GetComponent<RectTransform>();

        iconObject = new GameObject();
        Image iconImage = iconObject.AddComponent<Image>();
        iconImage.sprite = iconSprite;

        iconRect = iconObject.GetComponent<RectTransform>();
        iconRect.SetParent(canvas.transform);
        
        // Initial state is off until player enters the trigger
        iconObject.SetActive(false);
        open = 0;
    }

    void Update()
    {
        // Get the position on the canvas
        Vector2 ViewportPosition = Camera.main.WorldToViewportPoint(transform.position + iconOffset);
        Vector2 proportionalPosition = new Vector2(ViewportPosition.x * canvasRect.sizeDelta.x, ViewportPosition.y * canvasRect.sizeDelta.y);
        
        iconRect.localPosition = proportionalPosition - (canvasRect.sizeDelta / 2);

        if (open == 1 && Input.GetKey(KeyCode.E))
        {
            vaultDoor.transform.Rotate(0f, 135f, 0f, Space.Self);
            open = 2;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player" && open == 0)
        {
            iconObject.SetActive(true);
            open = 1;
            //NavMeshAgent agent = testAgentObject.GetComponent<NavMeshAgent>();
            //agent.destination =  transform.position;
        }
    }

    void OnTriggerExit(Collider c)
    {
        iconObject.SetActive(false);
    }
}
