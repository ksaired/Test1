using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class MusicSettingsFacade : SettingsFacade
{
   public virtual Slider currentSlider { protected set; get; }
   public virtual float SoundVolume { protected set; get; }

   public virtual void ChangeMusicVolume(float NewMusicVolume)
   {
        SoundVolume = NewMusicVolume;
   }

   public override void StartFacade()
   {
        CurrentSettingsInfo = UIInfo.settingsInformation;
   }
   public override bool IsChange(SettingSaveInfo PreviusSaveInfo)
   {
      if (PreviusSaveInfo.SoundsVolume.TryGetValue(ObjectPath,out float LoadSoundsVolume))
      {
         if (SoundVolume != LoadSoundsVolume)
         {
            return true;
         }
      }

      return false;
   }
   public override void Load()
   {
        if (UIInfo.settingsInformation.SoundsVolume.TryGetValue(ObjectPath, out float LoadSoundsVolume))
        {
            SoundVolume = LoadSoundsVolume;
        }

        currentSlider = GetComponent<Slider>();

        currentSlider.value = SoundVolume;
    }
   public override void Save()
   {
        if (UIInfo.settingsInformation.SoundsVolume.ContainsKey(ObjectPath))
        {
            UIInfo.settingsInformation.SoundsVolume.Remove(ObjectPath);
            UIInfo.settingsInformation.SoundsVolume.Add(ObjectPath,SoundVolume);
        }
        else
        {
            UIInfo.settingsInformation.SoundsVolume.Add(ObjectPath, SoundVolume);
        }
   }
}
