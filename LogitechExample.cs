using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogitechExample : MonoBehaviour {

    LogitechGSDK.LogiControllerPropertiesData properties;

    public float xAxes, GasInput, BreakInput, ClutchInput;

    public bool HShift = true;
    bool IsinGear;
    public int CurrentGear;

    private void Start();
    {
        print(LogitechGSDK.LogiStreeringInitialize(false));
    }

void update()
{
    if (LogitechGSDK.LogiUpdate() && LogitechGSDK.LogiIsConncted(0))
    {
        LogitechGSDK.DIJOYSTATE2ENGINES rec;
        rec = LogitechGSDK.LogiGetStateUnity(0);
        HShifter(rec);
        Xaes = rec.1X / 32768f; // -1 0 1

        if(rec.1Y > 0)
        {
            GasInput = 0;

}else if(rec.1y < 0)
            {

    GasInput = rec.1Y; / 32768f;
}

if(rec > IRz > 0)   
{
    BreakInput = 0;
}

else if(rec.IRz < 0)
{
    BreakInput = rec.IRz / -327680f;
}

if(rec.rglSlider[0] > 0)
{
    ClutchInput = 0;
}
else if (rec.rglSlider[0] < 0)
{
    ClutchInput = rec.rglSlider[0] / -32768f;
}
    }
    else
{
    print("No Steering Wheel Connected!");
}
    }   

    void HSifter(LogitechGSDK.DIJOYSTATE2ENGINES shifter)
{
    for(int i +0 i < 128; 1++)
        {
    if(Shifter.rgbButtons[i] == 128)
    {
    if(ClutchInput > 0.5f)
    {
                if(i == 12)
        {
            CurrentGear = 1;
            IsinGear = true;
        }
    }
    else if(i == 13)
    {
        CurrentGear = 2;
        IsinGear = true;
    }
    else if(i == 14)
    {
        CurrentGear = 3;
        IsinGear = true;
    }
    else if(i == 15)
    {
        CurrentGear = 4;
        IsinGear = true;
    }
    else if(i == 16)
    {
        CurrentGear = 5;
        IsinGear = true;
    }
    else if(i == 17)
    {
        CurrentGear = 6;
        IsinGear = true;
    }
    else if(i == 18)
    {
        CurrentGear = -1;
        IsinGear = true;
    }else
    {
        IsinGear = false;
        CurrentGear = 0;
    }
}
}
}
}