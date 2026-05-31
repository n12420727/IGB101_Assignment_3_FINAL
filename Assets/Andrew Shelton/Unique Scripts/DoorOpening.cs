using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public Animator animator;
    public string triggerName = "PlayAnim";
    public bool onlyTriggerOnce = true;

    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (onlyTriggerOnce && hasTriggered)
            return;

        if (other.CompareTag("Player"))
        {
            animator.SetTrigger(triggerName);
            hasTriggered = true;
        }
    }
}