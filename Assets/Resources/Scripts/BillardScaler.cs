using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class BillardScaler : MonoBehaviour
{
    public Toggle scaleCheckbox;
    public XRGrabInteractable grabInteractable;
    public Transform billiardArea;
    public Text scalingFactorText; 

    private void Start()
    {
        // Listener for togglechange
        scaleCheckbox.onValueChanged.AddListener(OnScaleCheckboxValueChanged);
    }

    private void OnScaleCheckboxValueChanged(bool isOn)
    {
        grabInteractable.enabled = isOn;
    }

    private void Update()
    {
        // Check if scaling is enabled.
        if (scaleCheckbox.isOn)
        {
            // Get the current scaling factor of the Billiard area.
            Vector3 currentScale = billiardArea.localScale;
            float scalingFactor = currentScale.x;

        
            scalingFactorText.text = "Scaling: " + scalingFactor.ToString("F2");
        }
    }
}
