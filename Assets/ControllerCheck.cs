using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NRKernal;
using NRKernal.Release;

public class ControllerCheck : MonoBehaviour
{
    bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        ToggleObject(isEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (NRInput.IsTouching()) isEnabled = !isEnabled;
    }

    void ToggleObject(bool isEnabled)
    {
        this.gameObject.SetActive(isEnabled);
    }
}
