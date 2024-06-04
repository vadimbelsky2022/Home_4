using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 CameraOffset = new Vector3(0f, 5.0f, -3.0f);
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Robot").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CameraOffset);
        this.transform.LookAt(_target);
    }
}
