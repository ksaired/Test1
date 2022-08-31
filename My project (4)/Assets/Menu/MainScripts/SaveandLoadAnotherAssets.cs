using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveandLoadAnotherAssets : MonoBehaviour
{
    private FindOfUI findOfUI = new FindOfUI();

    public void Load()
    {
        LoadTextAssets();
        LoadSpriteAssets();
    }
    public void Save()
    {
        SaveSpriteAssets();
    }

    public void LoadTextAssets()
    {
        if (UIInfo.saveInformation.DictionaryOfText.TryGetValue(UIInfo.settingsInformation.CurrentLanguage,out Dictionary<string,string> CurrentDictionaryOfText))
        {
            foreach (var i in findOfUI.FindAllText())
            {
                if (CurrentDictionaryOfText.TryGetValue(i.TextPath,out string CurrentText))
                {
                    i.LoadText(CurrentText);
                }
            }
        }
    }
    public void LoadSpriteAssets()
    {
        foreach (var i in findOfUI.FindAllSpriteFacade())
        {
            if (UIInfo.saveInformation.SpritePath.TryGetValue(i.SpriteFacadePath,out string LoadPathToSprite))
            {
                i.ChangePathToassets(LoadPathToSprite);
            }

            i.LoadSprite();
        }
        
    }
    public void SaveSpriteAssets()
    {
        foreach (var i in findOfUI.FindAllSpriteFacade())
        {
            if (UIInfo.saveInformation.SpritePath.ContainsKey(i.SpriteFacadePath))
            {
                UIInfo.saveInformation.SpritePath.Remove(i.SpriteFacadePath);
                UIInfo.saveInformation.SpritePath.Add(i.SpriteFacadePath,i.PathToSprite);
            }
            else
            {
                UIInfo.saveInformation.SpritePath.Add(i.SpriteFacadePath, i.PathToSprite);
            }
        }
    }

   
}
