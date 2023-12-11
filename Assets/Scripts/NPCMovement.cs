using UnityEngine;

public class NPCMovementWithAnimations : MonoBehaviour
{
    public float walkSpeed = 1.0f;
    public float runSpeed = 2.0f;
    public float slideSpeed = 2.0f;
    public Animator animator;

    private enum NPCState
    {
        Walking,
        Running,
        Sliding
    }

    private NPCState currentState = NPCState.Walking;

    void Update()
    {
        switch (currentState)
        {
            case NPCState.Walking:
                Move(walkSpeed);

                // Transition to running when a certain condition is met (e.g., pressing a button)
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentState = NPCState.Running;
                    // Trigger the running animation
                    animator.SetBool("IsRunning", true);
                }
                break;

            case NPCState.Running:
                Move(runSpeed);

                // Transition to sliding when a certain condition is met (e.g., pressing another button)
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    currentState = NPCState.Sliding;
                    // Trigger the sliding animation
                    animator.SetBool("IsRunning", false); // Stop the running animation
                    animator.SetBool("IsSliding", true);
                }
                break;

            case NPCState.Sliding:
                Move(slideSpeed);

                // Transition back to walking after a sliding duration
                StartCoroutine(TransitionToWalkingAfterDelay(2.0f));
                break;
        }
    }

    void Move(float speed)
    {
        // Implement the movement logic based on the input speed
        // ...

        // For example:
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    System.Collections.IEnumerator TransitionToWalkingAfterDelay(float delay)
    {
        // Wait for the specified delay before transitioning to walking
        yield return new WaitForSeconds(delay);

        currentState = NPCState.Walking;
        // Trigger the walking animation
        animator.SetBool("IsSliding", false); // Stop the sliding animation
    }
}
