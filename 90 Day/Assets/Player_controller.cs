using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    

    public CharacterController controller;
    public float speed = 4f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direct = new Vector3(horizontal, 0f, vertical).normalized;

        if (direct.magnitude >= 0.1f)
        {
            controller.Move(direct * speed * Time.deltaTime);
        }
    }
}
