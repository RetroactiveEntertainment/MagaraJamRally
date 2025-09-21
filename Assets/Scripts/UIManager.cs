using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] PrometeoCarController carController;

    [SerializeField] GameObject finishCanvas, outTrackCanvas, deadEndCanvas;



    public void GameEndCanvas()
    {
        finishCanvas.SetActive(true);
        carController.enabled = false;
    }

    public void EnableOutTrack()
    {
        outTrackCanvas.SetActive(true);
    }

    public void DeadEndCanvas()
    {
        deadEndCanvas.SetActive(true);
        outTrackCanvas.SetActive(false);
        carController.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PlayButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
