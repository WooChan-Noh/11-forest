using UnityEngine;
using UnityEngine.UI;

public class NightScript : MonoBehaviour
{
    public Button animation1;
    public Button animation2;
    public Button animation3;
    public Button animation4;

    private Animator animator;
    private AnimatorStateInfo stateInfo;

    void Start()
    {
        animation1.onClick.AddListener(() => CheckButton(animation1));
        animation2.onClick.AddListener(() => CheckButton(animation2));
        animation3.onClick.AddListener(() => CheckButton(animation3));
        animation4.onClick.AddListener(() => CheckButton(animation4));

        animator = GetComponent<Animator>();
    }
    void Update()
    {
        CheckAnimation();
    }
    void CheckAnimation()
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float animationDone = stateInfo.normalizedTime;

        if (animator.GetBool("DANCE") == true)
        {
            if (animationDone >= 1.0f)
            {
                animator.SetBool("DANCE", false);

            }
            return;
        }

        if (animator.GetBool("SICK") == true)
        {
            if (animationDone >= 1.0f)
            {
                animator.SetBool("SICK", false);

            }
            return;
        }

        if (animator.GetBool("DRINK") == true)
        {
            if (animationDone >= 1.0f)
            {
                animator.SetBool("DRINK", false);
       
            }
            return;
        }

        if (animator.GetBool("SLEEP") == true)
        {
            if (animationDone >= 1.0f)
            {
                animator.SetBool("SLEEP", false);
            }
            return;
        }
    }
    void CheckButton(Button button)
    {
        if (button.name == "animationButton")
        {
            animator.SetBool("DANCE", true);

            animator.SetBool("SICK", false);
            animator.SetBool("SLEEP", false);
            animator.SetBool("DRINK", false);
        }
        else if (button.name == "animationButton2")
        {
            animator.SetBool("SICK", true);

            animator.SetBool("DANCE", false);
            animator.SetBool("SLEEP", false);
            animator.SetBool("DRINK", false);
        }
        else if (button.name == "animationButton3")
        {
            animator.SetBool("SLEEP", true);

            animator.SetBool("DRINK", false);
            animator.SetBool("DANCE", false);
            animator.SetBool("SICK", false);
        }
        else if (button.name == "animationButton4")
        {
            animator.SetBool("DRINK", true);

            animator.SetBool("DANCE", false);
            animator.SetBool("SICK", false);
            animator.SetBool("SLEEP", false);
        }
    }
}
