using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform sphereTransform;    
    void Start() {
        // set a game object's transform to the parent's transform
        sphereTransform.parent = transform;

        // scale a game object
        sphereTransform.localScale = Vector3.one * 2;
    }

    void Update() {
        // rotate the game object by 180 on the y axis, relative to the parent
        transform.Rotate(Vector3.up * Time.deltaTime * 180);

        // rotate the game object by 180 on the y axis, relative to the world
        transform.Rotate(Vector3.up * Time.deltaTime * 180, Space.World);

        // move the game object by 180 on the z axis, relative to the parent
        transform.Translate(Vector3.forward * Time.deltaTime * 7);

        // move the game object by 180 on the z axis, relative to the world
        transform.Translate(Vector3.forward * Time.deltaTime * 7, Space.World);

        if (Input.GetKeyDown(KeyCode.Space)) {
            // reset the position of the child game object to zero, relative to the parent's position
            sphereTransform.position = Vector3.zero;

            // reset the position of the child game object to zero in global space
            sphereTransform.position = Vector3.zero;
        }
    }
}
