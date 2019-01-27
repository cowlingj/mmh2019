using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    public GameObject target;

    public int ResourceA;
    public int ResourceB;
    public int ResourceC;

    public string Name;
    public string FlavorText;

    static public GameObject nametext;
    static public GameObject flavourtext;
    static public GameObject resourcea;
    static public GameObject resourceb;
    static public GameObject resourcec;

    static Text nameyboi = nametext.GetComponent<Text>();
    static Text flavourboi = flavourtext.GetComponent<Text>();
    static Text boioA = resourcea.GetComponent<Text>();
    static Text boioB = resourceb.GetComponent<Text>();
    static Text boioC = resourcec.GetComponent<Text>();

    private bool ShouldTriggerPopUp()
    {
        Debug.Log(CrossPlatformInputManager.GetButton("Submit")
          && Vector3.Distance(transform.position, target.transform.position) < 3);
        return CrossPlatformInputManager.GetButton("Submit")
          && Vector3.Distance(transform.position, target.transform.position) < 3;
    }

    public Trigger ActivatePopUp;

    void Update()
    {
        ActivatePopUp.TestTrigger();
    }

    private void Awake()
    {
        ActivatePopUp = new Trigger(() => LandOnPlanet(ResourceA, ResourceB, ResourceC, Name, FlavorText), ShouldTriggerPopUp);
        //ActivatePopUp = new Trigger(() => Landing.LandOnPlanet(), ShouldTriggerPopUp);
    }

    public static void LandOnPlanet(int ResourceA, int ResourceB, int ResourceC, string Name, string FlavourText)
    //public static void LandOnPlanet()
    {
        Debug.Log("Landable");
        boioA.text = ResourceA.ToString();
        boioB.text = ResourceB.ToString();
        boioC.text = ResourceC.ToString();
        nameyboi.text = Name;
        flavourboi.text = FlavourText;
    }
}
