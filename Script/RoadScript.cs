using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class RoadScript : MonoBehaviour
{
    public Button animation1;
    public Button animation2;
    public Button animation3;
    public Button animation4;

    private NavMeshAgent agent;
    private float mySpeed;

    private Animator animator;
    private AnimatorStateInfo stateInfo;
    private bool sleepControl = false;

    public Transform[] wayPoint;
    private int movePoint;
    private int sleepPoint = 7;

    void Start()
    {
        animation1.onClick.AddListener(() => CheckButton(animation1));
        animation2.onClick.AddListener(() => CheckButton(animation2));
        animation3.onClick.AddListener(() => CheckButton(animation3));
        animation4.onClick.AddListener(() => CheckButton(animation4));

        animator = GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();
        mySpeed = agent.speed;

        movePoint = Random.Range(0, sleepPoint);

        StartMove();
    }
    void Update()
    {
        if(agent.remainingDistance <= agent.stoppingDistance && sleepControl== false)
            StartMove();
        
        CheckAnimation();

    }



    void StartMove()
    {
        agent.SetDestination(wayPoint[movePoint].position);

        int temp = movePoint;
        movePoint = Random.Range(0, sleepPoint);
        if(temp==movePoint)
        {
            while(true)
            {
                movePoint = Random.Range(0, sleepPoint);
                if (movePoint != temp)
                    break;
            }
        }
    }
  
    void CheckAnimation()
    {
       stateInfo = animator.GetCurrentAnimatorStateInfo(0);
       if (stateInfo.IsName("Walk") == true&& sleepControl==false)
            return;

       float animationDone = stateInfo.normalizedTime;

       if (animator.GetBool("DANCE") == true)
       {
           if (animationDone >= 1.0f)
           {
               animator.SetBool("DANCE", false);
               agent.speed = mySpeed;
           }
            return;
        }

       if (animator.GetBool("FALL") == true)
       {
           if (animationDone >= 1.0f)
           {
               animator.SetBool("FALL", false);
               agent.speed=mySpeed;
           }
            return;
        }

       if (animator.GetBool("SHOES") == true)
       {
           if (animationDone >= 1.0f)
           {
               animator.SetBool("SHOES", false);
               agent.speed = mySpeed;
           }
            return;
       }

       if(agent.remainingDistance <= agent.stoppingDistance  )
       {
           StopMove();
           animator.SetBool("SLEEP", true);
       }

      if (animationDone >= 1.0f)
      {
          animator.SetBool("SLEEP", false);
          agent.speed = mySpeed;
          sleepControl = false;
      }
  
  
    }


    void CheckButton(Button button)
    {
        if (button.name == "animationButton")
        {
            StopMove();
            animator.SetBool("DANCE", true);

            animator.SetBool("FALL", false);
            animator.SetBool("SLEEP", false);
            animator.SetBool("SHOES", false);
        }
        else if (button.name == "animationButton2")
        {
            StopMove();
            animator.SetBool("FALL", true);

            animator.SetBool("DANCE", false);
            animator.SetBool("SLEEP", false);
            animator.SetBool("SHOES", false);
        }
        else if (button.name == "animationButton3")
        {
            animator.SetBool("SHOES", false);
            animator.SetBool("DANCE", false);
            animator.SetBool("FALL", false);

            agent.SetDestination(wayPoint[sleepPoint].position);
            sleepControl = true;
            agent.speed = mySpeed; 
        }
        else if (button.name == "animationButton4")
        {
            StopMove();
            
            animator.SetBool("SHOES", true);

            animator.SetBool("DANCE", false);
            animator.SetBool("FALL", false);
            animator.SetBool("SLEEP", false);
        }

    }
    void StopMove()
    {
        agent.speed = 0;
    }
}   
