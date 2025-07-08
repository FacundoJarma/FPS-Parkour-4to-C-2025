using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InteractableArea : MonoBehaviour
{

    public GameObject interactionMsg;
    public MercanciaScript mercancia;

    bool onInteraction = false;
    GameObject gameObjectOfInteraction;

    private void Start()
    {
        interactionMsg.SetActive(false);
    }

    private void Update()
    {

        interactionMsg.SetActive(onInteraction);
        if (onInteraction && Input.GetKeyDown(KeyCode.E))
        {
            gameObjectOfInteraction.GetComponent<MercanciaScript>().onInteraction();
            stopInteraction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isInteractable = other.GetComponent<MercanciaScript>();
        if (isInteractable)
        {
            onInteraction = true;
            gameObjectOfInteraction = other.gameObject;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        stopInteraction();
    }
    
    void stopInteraction()
    {
        onInteraction = false;
        gameObjectOfInteraction = null;
    }
}
