using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetClickCheck : MonoBehaviour
{
    [SerializeField] GameObject _infoPanel;
    [SerializeField] TextMeshProUGUI _name;
    bool isActive;

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           if(Physics.Raycast(ray, out raycastHit))
           {
            if(raycastHit.transform != null)
            {
               ActivePanel();
               ClickedGameObject(raycastHit.transform.gameObject);
            }
           }
            
        }
    }

    public void ClickedGameObject(GameObject gameObject)
    {
        if(gameObject.tag == "Planets")
        {
            _name.text = "Planet's name: " + gameObject.name;
        }
    }

    public void ActivePanel()
    {
        isActive = true;
        _infoPanel.SetActive(isActive);
        
    }
    public void DisablePanel()
    {
        isActive = false;
        _infoPanel.SetActive(isActive);
    }
}
