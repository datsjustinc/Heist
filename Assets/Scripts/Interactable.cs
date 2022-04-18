using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    public Sprite iconSprite;
    public Vector3 iconOffset;
    public GameObject testAgentObject;
    public GameObject testAgentObject2;

    private Canvas canvas;
    private RectTransform canvasRect;
    private RectTransform iconRect;
    private GameObject iconObject;

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
    }

    void Update()
    {
        // Get the position on the canvas
        Vector2 ViewportPosition = Camera.main.WorldToViewportPoint(transform.position + iconOffset);
        Vector2 proportionalPosition = new Vector2(ViewportPosition.x * canvasRect.sizeDelta.x, ViewportPosition.y * canvasRect.sizeDelta.y);
        
        iconRect.localPosition = proportionalPosition - (canvasRect.sizeDelta / 2);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            iconObject.SetActive(true);

            if (gameObject.tag == "Right")
            {
                transform.Rotate(0f, -90f, 0f, Space.Self);
            }

            if (gameObject.tag == "Left")
            {
                transform.Rotate(0f, 90f, 0f, Space.Self);
            }

            //bank = true;

            NavMeshAgent agent = testAgentObject.GetComponent<NavMeshAgent>();
            agent.destination =  testAgentObject2.transform.position;
        }
    }

    void OnTriggerExit(Collider c)
    {
        iconObject.SetActive(false);

        if (gameObject.tag == "Right")
        {
            transform.Rotate(0f, 90f, 0f, Space.Self);
        }

        if (gameObject.tag == "Left")
        {
            transform.Rotate(0f, -90f, 0f, Space.Self);
        }
    }
}
