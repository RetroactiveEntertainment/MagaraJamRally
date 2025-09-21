using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] PrometeoCarController carController;

    [SerializeField] GameObject finishCanvas;



    public void GameEndCanvas()
    {
        finishCanvas.SetActive(true);
        carController.enabled = false;
    }
}
