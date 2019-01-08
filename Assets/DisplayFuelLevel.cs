
using UnityEngine;
using UnityEngine.UI;

public class DisplayFuelLevel : MonoBehaviour
{
    public Spacecraft spacecraft;
    public Slider slider;
   

    // Update is called once per frame
    void Update()
    {
        slider.value = spacecraft.getFuelLevel();
    }
}
