using System;
using UnityEngine;
using UnityEngine.UI;

public class RotateOnAxis : MonoBehaviour
{
    [Tooltip("Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that order).")]
    public Vector3 rotationSpeed;
    public GameObject m_Canvas;

    private void Start()
    {
        m_Canvas = GameObject.Find("Canvas");
    }
    void Update()
    {
        if (Vector3.Distance(Input.mousePosition, m_Canvas.transform.position) < 20f)
        {
            transform.Rotate(rotationSpeed * 2);
            Debug.Log("faster");
            return;
        }
        transform.Rotate(rotationSpeed);
        Debug.Log(Input.mousePosition);
    }
}
