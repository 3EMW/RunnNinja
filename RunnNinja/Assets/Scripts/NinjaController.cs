using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    [SerializeField] private float minXValue = -2f;
    [SerializeField] private float maxXValue = 2f;
    public float xSpeed;
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        farePos.x = Mathf.Clamp(farePos.x, minXValue, maxXValue);
        base.transform.position = new Vector3(farePos.x, base.transform.position.y, base.transform.position.z);

    }
}
