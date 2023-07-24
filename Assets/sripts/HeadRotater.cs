using UnityEngine;

[RequireComponent(typeof(Animator))]
public class HeadRotater : MonoBehaviour
{
    protected Animator animator;

    public bool ikActive = false;
    public Transform lookObj = null;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK()
    {
        if (animator)
        {
            if (ikActive)
            {
                if (lookObj != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }
            }
            else
            {
                animator.SetLookAtWeight(0);
            }
        }
    }
}
