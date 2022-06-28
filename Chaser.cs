using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 direction = displacementFromTarget.normalized;
        Vector3 velocity = direction * speed;
        float distanceToTarget = displacementFromTarget.magnitude;
        if (distanceToTarget > 1.5) {
            Vector3 moveAmount = velocity * Time.deltaTime;
            transform.Translate(moveAmount);
        } 
    }
}
