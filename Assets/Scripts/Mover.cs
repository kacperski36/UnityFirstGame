using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // Instructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    // void Instructions()
    // {
    //     Debug.Log("Witaj");
    //     Debug.Log("Witaj2");
    //     Debug.Log("Witaj3");
    // }
    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }
}
