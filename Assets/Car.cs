using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    string VillanName = "Sweet Tooth";
    int VillanHight = 170;
    int VillanAge = 43;
    string VillanSuperPower = "Last Laugh";

    string heroName = "Bat Mobile";
    int heroHight = 191;
    int heroAge = 45;
    string heroSuperPower = "Long night";

    // Start is called before the first frame update
    void Start()
    {
        print("The Villan name is " + VillanName + " and his hight is " + VillanHight + " he is " + VillanAge + "year old and " + " his super power goes by the name ..." + VillanSuperPower);
        print("The hero name is " + heroName + " and his hight is " + heroHight + " he is " + heroAge + "year old and " + " his super power goes by the name ..." + heroSuperPower);

        int ageDiffernce = heroAge - VillanAge;
        heroHight += 5;
        VillanSuperPower = "None";

        print("The Villan name is " + VillanName + " and his hight is " + VillanHight + " he is " + VillanAge + "year old and " + " his super power goes by the name ..." + VillanSuperPower);
        print("The hero name is " + heroName + " and his hight is " + heroHight + " he is " + heroAge + "year old and " + " his super power goes by the name ..." + heroSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
