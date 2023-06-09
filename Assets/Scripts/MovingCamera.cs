using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    GameObject playerTarget;
    Vector3 offset;

    public float leftLimit, rightLimit, topLimit, bottomLimit;

    private void Start() {
        playerTarget = GameObject.FindWithTag("Player");
        offset = transform.position - playerTarget.transform.position;
    }

   
    private void Update() {
        transform.position = Vector3.Lerp(transform.position, playerTarget.transform.position + offset, 0.2f);

        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
            transform.position.z
        );
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(leftLimit, topLimit), new Vector2(rightLimit, topLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, topLimit));
        Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
    }
    
}
