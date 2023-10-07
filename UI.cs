using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text planetNameField;
    public string planetName;

    public Text AP_Field;
    public string AtmosphericPressure;
    public Text GC_Field;
    public string gravityCoefficient;
    public Text CG_Field;
    public string componentGasses;
    public Text MC_Field;
    public string MoonCount;

    // Start is called before the first frame update
    void Start()
    {
        planetNameField.text = planetName;
        AP_Field.text = AtmosphericPressure;
        GC_Field.text = gravityCoefficient;
        CG_Field.text = componentGasses;
        MC_Field.text = MoonCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
