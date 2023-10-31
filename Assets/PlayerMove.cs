using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 _movementInput,
            _orientationInput;

    public float _speed;
                 
    //Camera cam;
    
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        //cam = Camera.main;
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"),
              vertical = Input.GetAxisRaw("Vertical"),
              mouseX = Input.GetAxis("Mouse X"),
              mouseY = Input.GetAxis("Mouse Y");

        _movementInput = new Vector3(horizontal, 0, vertical).normalized;
        
        _orientationInput = new Vector3(mouseX,0, mouseY);
    }

    void LateUpdate()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 velocity = _movementInput * _speed;
        _rigidbody.velocity = velocity;

        Quaternion lookRotation = Quaternion.LookRotation(_orientationInput);
        _rigidbody.MoveRotation(lookRotation);
    }

    /*void OnGUI()
    {
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
    }*/

    private Transform _transform;
    private Rigidbody _rigidbody;
}
