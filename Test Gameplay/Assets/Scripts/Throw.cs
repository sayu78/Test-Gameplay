using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throw : MonoBehaviour
{
    public Slider slider;
    public float cap;
    public GameObject Ball;
    private float power;
    private float upPower;
    // Update is called once per frame
    void Update()
    {
        slider.maxValue = cap;
        slider.value = power;
        upPower = power + 2;
        Vector3 force = this.transform.forward * power * upPower;
        //Power cap
        if (power > cap)
        {
            power = cap;
        }
        Debug.Log(power);
        Debug.Log(upPower);
        //Throw Action
        if (Input.GetKey(KeyCode.Z) && Ball != null)
        {
            power += 0.1f;
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            Ball.GetComponent<Rigidbody>().isKinematic = false;
            Ball.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
            Ball.transform.parent = null;
            power = 0f;
        }

    }
}
