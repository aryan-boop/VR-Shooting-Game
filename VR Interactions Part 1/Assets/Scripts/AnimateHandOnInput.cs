using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;
    public GameObject bullet;
    public Transform spwanPoint;
    public float fireSpeed = 20;
    bool enablefire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        if (triggerValue > 0.7f)
        {
            if (enablefire == true)
            {
                GameObject spwanedBullet = Instantiate(bullet);
                spwanedBullet.transform.position = spwanPoint.position;
                spwanedBullet.GetComponent<Rigidbody>().velocity = spwanPoint.forward * fireSpeed;
                Destroy(spwanedBullet, 5);
                enablefire = false;
            }
        }

        if (triggerValue < 0.2f)
        {
            enablefire = true;
        }
    }
}
