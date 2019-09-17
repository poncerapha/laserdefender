using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;
    int waypointIndex = 0;
    void Start()
    {
        this.transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPos = waypoints[waypointIndex].transform.position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPos, movementThisFrame);

            if (this.transform.position == targetPos)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
