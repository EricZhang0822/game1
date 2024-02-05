using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float xInput;
    private float yInput;
    [SerializeField] private float moveSpeed;
    [SerializeField] Vector3 rotation;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject torch_object;
    [SerializeField] private Transform torch;
    [SerializeField] private AudioSource torch_sound;
    [SerializeField] private AudioSource walk_sound;
    private bool is_torch_on = true;
    [SerializeField] private float torch_timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        torch = GameObject.Find("light 2D").transform;
        torch_object = GameObject.Find("light 2D").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        torch_timer -= Time.deltaTime;
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(xInput * moveSpeed, yInput * moveSpeed);

        //why??
        if (xInput == 0 && yInput == 0)
            walk_sound.Play();

        if (Input.GetKey(KeyCode.E))
        {
            torch.transform.Rotate(-rotation);
        }else if (Input.GetKey(KeyCode.Q))
        {
            torch.transform.Rotate(rotation);
        }else if (Input.GetKeyDown(KeyCode.C) && torch_timer < 0)
        {
            torch_object.SetActive(!is_torch_on);
            is_torch_on = !is_torch_on;
            torch_sound.Play();
            torch_timer = 2;
        }


    }
}
