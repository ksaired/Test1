using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MusicVolume : MusicSettingsFacade
{
    public override Slider currentSlider { get => base.currentSlider; protected set => base.currentSlider = value; }
    public override SettingSaveInfo CurrentSettingsInfo { get => base.CurrentSettingsInfo; protected set => base.CurrentSettingsInfo = value; }

    public override string ObjectPath { get => DeffaultObjectPath; protected set => DeffaultObjectPath = value; }
    public override float SoundVolume { get => DeffaultSoundsVolume; protected set => DeffaultSoundsVolume = value; }

    private string DeffaultObjectPath = "MusicVolume";
    private float DeffaultSoundsVolume = 100f;

    public override void ChangeObjectPath(string NewObjectPath)
    {
        base.ChangeObjectPath(NewObjectPath);
    }
    public override void ChangeSettingsInfo(SettingSaveInfo NewCurrentSettingsInfo)
    {
        base.ChangeSettingsInfo(NewCurrentSettingsInfo);
    }
    public override void ChangeMusicVolume(float NewMusicVolume)
    {
        base.ChangeMusicVolume(NewMusicVolume);
    }
    
    public override void StartFacade()
    {
        base.StartFacade();
    }
    public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
    {
        return base.IsChange(PreviusSaveInfo);
    }
    public override void Load()
    {
        base.Load();
    }
    public override void Save()
    {
        base.Save();
    }
}
