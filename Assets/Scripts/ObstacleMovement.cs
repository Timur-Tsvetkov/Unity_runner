using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float force = 150f;
    public Vector3 collisionVelocity = new Vector3(25f, 5f, 10f);

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                Rigidbody obstacle = GetComponent<Rigidbody>();
                obstacle.velocity = new Vector3(obstacle.velocity.x, collisionVelocity.y, collisionVelocity.z);
                obstacle.angularVelocity *= collisionVelocity.x;

                //FindObjectOfType<GameManger>().InitiateDeath();
                break;
            case "ObstacleWall":
                Destroy(gameObject);
                break;
        }
    }
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(0f, 0f, -force);
    }
}