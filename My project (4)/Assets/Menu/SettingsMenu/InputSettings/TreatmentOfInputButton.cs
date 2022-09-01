using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreatmentOfInputButton : InputSettingsFacade
{
    public override SettingSaveInfo CurrentSettingsInfo { get => base.CurrentSettingsInfo; protected set => base.CurrentSettingsInfo = value; }
    public override KeyCode currentTreatmenButtonValue { get => base.currentTreatmenButtonValue; protected set => base.currentTreatmenButtonValue = value; }

    public override string ObjectPath { get => DeffaultSettingsPath; protected set => DeffaultSettingsPath = value; }
    public override bool IsChooseButton { get => base.IsChooseButton; protected set => base.IsChooseButton = value; }
    

    private string DeffaultSettingsPath = "Keyboard and Mouse";
   
    public void ChangeButtonValue(InputButtonValueFacade currentButton)
    {
        if (!IsChooseButton)
        {
            BeginInputChoose(currentButton);
        }
        else if(IsChooseButton)
        {
            
            if (currentButton.ButtonValue != currentTreatmenButtonValue)
            {
                FindPreviusButton(currentButton.ButtonValue);
                currentButton.ChangeOfButtonValue(currentTreatmenButtonValue);
                StopChoose(currentButton);
            }
            else if (currentButton.ButtonValue == currentTreatmenButtonValue)
            {
                currentButton.GetComponent<Image>().sprite = currentButton.DefaultSprite;
                StopChoose(currentButton);
            }
        }
       

    }
    private void StopChoose(InputButtonValueFacade currentButton)
    {
        if (currentButton.gameObject.GetComponentInChildren<Text>())
        {
            currentButton.gameObject.GetComponentInChildren<Text>().text = currentButton.ButtonValue.ToString();
        }
        IsChooseButton = false;
    }
    private void FindPreviusButton(KeyCode newValue)
    {
        foreach (var i in gameObject.GetComponentsInChildren<InputButtonValueFacade>())
        {
            if (i.ButtonValue == currentTreatmenButtonValue)
            {

                i.ChangeOfButtonValue(newValue);
                i.GetComponent<Image>().sprite = i.DefaultSprite;

                if (i.gameObject.GetComponentInChildren<Text>())
                {
                  i.gameObject.GetComponentInChildren<Text>().text = i.ButtonValue.ToString();
                }
                
            }
        }
    }
    private void BeginInputChoose(InputButtonValueFacade currentButton)
    {
        currentTreatmenButtonValue = currentButton.ButtonValue;
        currentButton.ChangeDeffaultSprite(currentButton.gameObject.GetComponent<Image>().sprite);
        currentButton.LoadSrite(currentButton.SpriteLink);
        IsChooseButton = true;
    }

    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
    }
    public override void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        base.ChangeSettingsInfo(NewCurrentSettingsInfo);
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        return base.IsChange(PreviusSaveInfo);
    }
    public override void StartFacade()
    {
        base.StartFacade();
    }
    public override void Load()
    {
        base.Load();
    }
    public override void Save()
    {
        base.Save();
    }
    public override void StartChildren()
    {
        base.StartChildren();
    }

}
