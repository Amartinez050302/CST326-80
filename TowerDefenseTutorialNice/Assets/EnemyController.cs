using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public string targetName = "Destination"; // the name of the destination GameObject
    NavMeshAgent agent;
    Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find(targetName).transform;
    }

    void Update()
    {
        if (agent != null && target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}