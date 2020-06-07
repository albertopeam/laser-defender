using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float oneRotationEachSeconds = 2f;

    // Update is called once per frame
    void Update()
    {
        float deltaRotation = 360 * Time.deltaTime / oneRotationEachSeconds;

        Transform transform = gameObject.transform;
        float newRotation = transform.rotation.z + deltaRotation;

        transform.Rotate(new Vector3(0, 0, newRotation));
    }
}
