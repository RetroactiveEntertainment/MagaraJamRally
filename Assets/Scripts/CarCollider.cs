using UnityEngine;

public class CarCollider : MonoBehaviour
{
    [SerializeField] UIManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finishline")
        {
            manager.GameEndCanvas();
        }

        if (other.tag == "OutTrack")
        {
            manager.EnableOutTrack();
        }

        if (other.tag == "DeadEnd")
        {
            manager.DeadEndCanvas();
        }
    }
}
