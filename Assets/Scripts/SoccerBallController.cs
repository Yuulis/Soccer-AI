using UnityEngine;

public class SoccerBallController : MonoBehaviour
{
    public GameObject area;
    [HideInInspector] public SoccerEnvController envController;

    // will be used to check if collided with purple goal
    public string purpleGoalTag;

    // will be used to check if collided with blue goal
    public string blueGoalTag;

    void Start()
    {
        envController = area.GetComponent<SoccerEnvController>();
    }

    void OnCollisionEnter(Collision col)
    {
        // ball touched purple goal
        if (col.gameObject.CompareTag(purpleGoalTag))
        {
            envController.GoalTouched(Team.Blue);
        }

        //ball touched blue goal
        if (col.gameObject.CompareTag(blueGoalTag))
        {
            envController.GoalTouched(Team.Purple);
        }
    }
}
