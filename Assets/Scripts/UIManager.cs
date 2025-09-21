using UnityEngine;

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
}
