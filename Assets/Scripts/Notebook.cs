using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    public List<GameObject> pages = new List<GameObject>();
    public int currentPageIndex;
    public float prevMousePositionY;
    public Camera dashCam;
    public float raycastMaxDistance = 10f;
    public bool lastClickedOnNotebook = false;

    private void Start()
    {
        pages[0].SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = dashCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, raycastMaxDistance))
            {
                if (hit.collider.gameObject.CompareTag("Notebook"))
                {
                    prevMousePositionY = Input.mousePosition.y;
                    lastClickedOnNotebook = true;
                }
                else
                {
                    Debug.Log("Hit smth else than notebook, it is " + hit.collider.gameObject.name);
                }
            }
            else
            {
                Debug.Log("No hit");
            }
        }

        if (Input.GetMouseButtonUp(0) && Input.mousePosition.y < prevMousePositionY && lastClickedOnNotebook)
        {
            Debug.Log("prev");
            lastClickedOnNotebook = false;
            SwitchToPrevPage();
        }

        else if (Input.GetMouseButtonUp(0) && Input.mousePosition.y > prevMousePositionY && lastClickedOnNotebook)
        {
            Debug.Log("next");
            lastClickedOnNotebook = false;
            SwitchToNextPage();
        }
    }


    public void SwitchToNextPage()
    {
        if (currentPageIndex == pages.Count - 1 || pages.Count == 0)
            return;

        pages[currentPageIndex].SetActive(false);
        pages[++currentPageIndex].SetActive(true);
    }

    public void SwitchToPrevPage()
    {
        if (currentPageIndex == 0 || pages.Count == 0)
            return;

        pages[currentPageIndex].SetActive(false);
        pages[--currentPageIndex].SetActive(true);
    }
}