using UnityEngine;
public class WakeUpWhenHit : MonoBehaviour
{
    public Animator animatorController;
    private void OnTriggerEnter(Collider other) 
    {
        animatorController.SetTrigger("Wakeup");
        print("setting trigger Wakeup");
    }
    private void OnTriggerExit(Collider other)
    {
        animatorController.SetTrigger("Sleep");
        print("setting trigger: SLEEP");
    }
}