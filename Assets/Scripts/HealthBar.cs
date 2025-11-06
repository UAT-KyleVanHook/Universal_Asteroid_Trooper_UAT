using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField] private Slider healthSlider;
    //main camera
    [SerializeField] private Camera mainCamera;
    //target that the object is attached to
    [SerializeField] private Transform target;
    //offset
    [SerializeField] private Vector3 offset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the main camera
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Update our healthbar so that its rotation is that of the main camera.
        //It shouldn't rotate if the object its attached to rotates.
        transform.rotation = mainCamera.transform.rotation;

        //position of the healthbar above objects head.
        transform.position = target.position + offset;
    }

    public void UpdateHealthBar(float currValue, float maxValue)
    {
        healthSlider.value = currValue / maxValue;  
    }
}
