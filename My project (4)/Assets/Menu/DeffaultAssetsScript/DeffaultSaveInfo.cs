using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeffaultSaveInfo
{

    public Dictionary<string, Dictionary<string, string>> DictionaryOfText = new Dictionary<string, Dictionary<string, string>>()
    {
        {"Русский", new Dictionary<string, string>()
          {
            //MainMenuText
            {"TextOfOpenLoadMenuButton","Загрузочное меню" },
            {"TextOfOpenSettingsMenuButton","Меню Настроек" },
            {"TextOfStartButton","Старт" },
            {"TextOfExitButton","Выйти" },

            //PauseMenuText
            {"TextOfLoadPauseLoadMenu","Загрузить Меню Сохранений "},
            {"TextOfLoadPauseSaveMenu","Загрузить Меню Загрузки" },
            {"TextOfPauseExitButton","Пауза" },
            {"TextOfExitFromGameButton","Выйти из игры" },

            //SettingsMenuText
            {"TextOfOpenSoundsSettingsMenuButton","Меню Звуковое" },
            {"TextOfOpenGraphicSettingsMenuButton","Меню Настроек Графики" },
            {"TextOfOpenInputSettingsMenuButton","Меню Управления" },
            {"TextOfOpenGameSettingsMenu","Меню Настроек игры" },

            //GraphickSettingsMenuText
            {"TextOfHighLevelOfGraphic","High " },
            {"TextOfMediumLevelOfGraphic","Medium " },
            {"TextOfMinimalLevelOfGraphic","Minimal " },
            {"TextOfYourSelfulLevelOfGraphic","YouSerfullGraphic" },
            {"TextOfOverallLevelOfGrahic","LevelOfGraphic" },
            {"TextOfLevelTexture","Texture" },

            //WhetherDeleteGameSaveMenuText
            {"TextOfWhetherDeleteGameSaveTable","Whether Delete Game Save ?" },
            {"TextOfYesDeleteGameSaveButton","Yes,Delete Game Save" },
            {"TextOfNoDeleteGameSaveButton","No,don't Delete Game Save" },

            //OpenGameSaveMenuText
            {"TextOfYesOpenGameSaveButton","Yes,Open" },
            {"TextOfNoOpenGameSaveButton","No,don't open this GameSave" },
            {"TextOfOpenGameSaveTable","Do you like to open this Game Save ?" },

            //ChooseOfDifficultMenyText
            {"TextOfChooseDifficultOfGameTable","What you want to choose difficult of game ?" },
            {"TextOfEasyDifficultOfGameButton","Easy" },
            {"TextOfMediumDifficultOfGameButton","Medium" },
            {"TextOfHardDifficultOfGameButton","Hard" },

            //CreateNewGameSaveMenuText
            {"TextOfCreateNewGameSaveInfoButton","Yes,create new Game Save" },
            {"TextOfNoCreateNewGameSaveButton","No,don't create new game save" },
            {"TextOfWhetherCreateNewGameSaveTable","Do you like  create new game save ?" },

            //SaveGameSaveMenuText
            {"TextOfSaveGameSaveInfoButton","Yes, Save the Game" },
            {"TextOfNoSaveGameSaveButton","No,don't Save the Game ?" },
            {"TextOfWhetherSaveGameSaveTable","Do you like Save the Game ?" },

            //ExitFromGameSaveGameSaveMenuText
            {"TextOfLoadExitFromGameInMainMenu","Do you like to save the game ?" },
            {"TextOfSaveGameSaveExitFromGameInMainMenu"," save the game " },
            {"TextOfNoSaveGameSaveExitFromGameInMainMenu","Don't save the game " },

            //SaveChangeMenuText
            {"TextOfSaveChangeButton","Yes,Save" },
            {"TextOfDon'tSaveChangeButton","No,Don't Save" },
            {"TextOfSaveWhetherChangeTable","Do you like to save change ?" },

            //DeleteGameSaveSorryMessageMenuText
            {"TextOfSorryMessageTable","Sorry,but GameSave don't exits " },
            {"TextOfSorryMesageOfDeleteGameSaveButton","Okay,I see" },
                     
            
            {"TextOfDeleteButton","Удалить Сохранение" },
            {"TextOfBackButton","Назад" } 
           }  
        },
        {"English",new Dictionary<string, string>()
          {
            //MainMenuText
            {"TextOfOpenLoadMenuButton","LoadMenu" },
            {"TextOfOpenSettingsMenuButton","SettingsMenu" },
            {"TextOfStartButton","Start" },
            {"TextOfExitButton","Exit" },

            //PauseMenuText
            {"TextOfLoadPauseLoadMenu","LoadGameSaveMenu" },
            {"TextOfLoadPauseSaveMenu","SaveGameSaveMenu" },
            {"TextOfPauseExitButton","Pause" },
            {"TextOfExitFromGameButton","ExitFromGame" },

            //SettingsMenuText
            {"TextOfOpenSoundsSettingsMenuButton","Sounds Settings" },
            {"TextOfOpenGraphicSettingsMenuButton","Graphic Settings" },
            {"TextOfOpenInputSettingsMenuButton","Input Settings" },
            {"TextOfOpenGameSettingsMenu","GameSettingsMenu" },

            //GraphickSettingsMenuText
            {"TextOfHighLevelOfGraphic","High " },
            {"TextOfMediumLevelOfGraphic","Medium " },
            {"TextOfMinimalLevelOfGraphic","Minimal " },
            {"TextOfYourSelfulLevelOfGraphic","YouSerfullGraphic" },
            {"TextOfOverallLevelOfGrahic","LevelOfGraphic" },
            {"TextOfLevelTexture","Texture" },

            //WhetherDeleteGameSaveMenuText
            {"TextOfWhetherDeleteGameSaveTable","Whether Delete Game Save ?" },
            {"TextOfYesDeleteGameSaveButton","Yes,Delete Game Save" },
            {"TextOfNoDeleteGameSaveButton","No,don't Delete Game Save" },

            //OpenGameSaveMenuText
            {"TextOfYesOpenGameSaveButton","Yes,Open" },
            {"TextOfNoOpenGameSaveButton","No,don't open this GameSave" },
            {"TextOfOpenGameSaveTable","Do you like to open this Game Save ?" },

            //ChooseOfDifficultMenyText
            {"TextOfChooseDifficultOfGameTable","What you want to choose difficult of game ?" },
            {"TextOfEasyDifficultOfGameButton","Easy" },
            {"TextOfMediumDifficultOfGameButton","Medium" },
            {"TextOfHardDifficultOfGameButton","Hard" },

            //CreateNewGameSaveMenuText
            {"TextOfCreateNewGameSaveInfoButton","Yes,create new Game Save" },
            {"TextOfNoCreateNewGameSaveButton","No,don't create new game save" },
            {"TextOfWhetherCreateNewGameSaveTable","Do you like  create new game save ?" },

            //SaveGameSaveMenuText
            {"TextOfSaveGameSaveInfoButton","Yes, Save the Game" },
            {"TextOfNoSaveGameSaveButton","No,don't Save the Game ?" },
            {"TextOfLoadExitFromGameInMainMenu","Do you like to save the game ?" },

            //ExitFromGameSaveGameSaveMenuText
            {"TextOfSaveGameSaveExitFromGameInMainMenu"," save the game " },
            {"TextOfNoSaveGameSaveExitFromGameInMainMenu","Don't save the game " },
            {"TextOfWhetherSaveGameSaveTable","Do you like Save the Game ?" },

            //SaveChangeMenuText
            {"TextOfSaveChangeButton","Yes,Save" },
            {"TextOfDon'tSaveChangeButton","No,Don't Save" },
            {"TextOfSaveWhetherChangeTable","Do you like to save change ?" },

            //DeleteGameSaveSorryMessageMenuText
            {"TextOfSorryMessageTable","Sorry,but GameSave don't exits " },
            {"TextOfSorryMesageOfDeleteGameSaveButton","Okay,I see" },
                              
            
            {"TextOfDeleteButton","Delete Game Save" },
            {"TextOfBackButton","Back" }
           }
        },
        {"Український",new Dictionary<string, string>()
          {
            //MainMenuText
            {"TextOfOpenLoadMenuButton","Завантажувальне меню" },
            {"TextOfOpenSettingsMenuButton","Меню Налаштувань" },
            {"TextOfStartButton","Старт" },
            {"TextOfExitButton","Вийти" },

            //PauseMenuText
            {"TextOfLoadPauseLoadMenu","Завантажити Меню Збереження" },
            {"TextOfLoadPauseSaveMenu","Завантажити Меню Завантаження" },
            {"TextOfPauseExitButton","Пауза" },
            {"TextOfExitFromGameButton","Вийти з гри" },

            //SettingsMenuText
            {"TextOfOpenSoundsSettingsMenuButton","Меню Звукове" },
            {"TextOfOpenGraphicSettingsMenuButton","Меню Налаштувань Графіки" },
            {"TextOfOpenInputSettingsMenuButton","Меню Управління" },
            {"TextOfOpenGameSettingsMenu","Меню Налаштувань гри" },

            //GraphickSettingsMenuText
            {"TextOfHighLevelOfGraphic","High " },
            {"TextOfMediumLevelOfGraphic","Medium " },
            {"TextOfMinimalLevelOfGraphic","Minimal " },
            {"TextOfYourSelfulLevelOfGraphic","YouSerfullGraphic" },
            {"TextOfOverallLevelOfGrahic","LevelOfGraphic" },
            {"TextOfLevelTexture","Texture" },

            //WhetherDeleteGameSaveMenuText
            {"TextOfWhetherDeleteGameSaveTable","Whether Delete Game Save ?" },
            {"TextOfYesDeleteGameSaveButton","Yes,Delete Game Save" },
            {"TextOfNoDeleteGameSaveButton","No,don't Delete Game Save" },

            //OpenGameSaveMenuText
            {"TextOfYesOpenGameSaveButton","Yes,Open" },
            {"TextOfNoOpenGameSaveButton","No,don't open this GameSave" },
            {"TextOfOpenGameSaveTable","Do you like to open this Game Save ?" },

            //ChooseOfDifficultMenyText
            {"TextOfChooseDifficultOfGameTable","What you want to choose difficult of game ?" },
            {"TextOfEasyDifficultOfGameButton","Easy" },
            {"TextOfMediumDifficultOfGameButton","Medium" },
            {"TextOfHardDifficultOfGameButton","Hard" },

            //CreateNewGameSaveMenuText
            {"TextOfCreateNewGameSaveInfoButton","Yes,create new Game Save" },
            {"TextOfNoCreateNewGameSaveButton","No,don't create new game save" },
            {"TextOfWhetherCreateNewGameSaveTable","Do you like  create new game save ?" },

            //SaveGameSaveMenuText
            {"TextOfSaveGameSaveInfoButton","Yes, Save the Game" },
            {"TextOfNoSaveGameSaveButton","No,don't Save the Game ?" },
            {"TextOfLoadExitFromGameInMainMenu","Do you like to save the game ?" },

            //ExitFromGameSaveGameSaveMenuText
            {"TextOfSaveGameSaveExitFromGameInMainMenu"," save the game " },
            {"TextOfNoSaveGameSaveExitFromGameInMainMenu","Don't save the game " },
            {"TextOfWhetherSaveGameSaveTable","Do you like Save the Game ?" },

            //SaveChangeMenuText
            {"TextOfSaveChangeButton","Yes,Save" },
            {"TextOfDon'tSaveChangeButton","No,Don't Save" },
            {"TextOfSaveWhetherChangeTable","Do you like to save change ?" },

            //DeleteGameSaveSorryMessageMenuText
            {"TextOfSorryMessageTable","Sorry,but GameSave don't exits " },
            {"TextOfSorryMesageOfDeleteGameSaveButton","Okay,I see" },


            {"TextOfDeleteButton","Видалити Збереження" },
            {"TextOfBackButton","Назад" }
           }
        }
    };
    public Dictionary<string, string> SpritePath = new Dictionary<string, string>() 
    {
        {"SpriteOfMainMenu","/Image5" },
        {"SpriteOfLoadGameSaveMenu","/Image5" },
        {"SpriteOfGraphicSettingsMenu","/Image6" },
        {"SpriteOfInputSettingsMenu","/Image6" },
        {"SpriteOfSettingsMenu","/Image5" },
        {"SpriteOfSoundsSettingsMenu","/Image5" },
        {"SpriteOfChooseDeleteGameSaveMenu","/Image5" },
        {"SpriteOfCheckOpenGameSave","/Image5" },
        {"SpriteOfChooseDifficultMenu","/Image5" },
        {"SpriteOfCheckCreateNewGameSaveMenu","/Image5" },
        {"SpriteOfCheckSaveGameSaveMenu","/Image6" },
        {"SpriteOfCheckSaveWhetherChangeMenu","/Image5" },
        {"SpriteOfGameSettingsMenu","/Image5" },
        {"SpriteOfLoadPauseMenu","/Image5" },
        {"SpriteOfSorryGameSaveMessageMenu","/Image5" },
        {"SpriteLoadExitFromGameInMainMenu","/Image6" },
        {"SpriteOfChooseDeleteGameSaveTable","/Image7" },
        {"SpriteOfCheckOpenSaveTable","/Image7" },
        {"SpriteOfChooseOfDifficultTable","/Image7" },
        {"SpriteOfCheckCreateNewGameSaveTable","/Image7" },
        {"SpriteOfCheckSaveGameSaveTable","/Image7" },
        {"SpriteOfCheckSaveWhetherChangeTable","/Image7" },
        {"SpriteOfSorryGameSaveMessageTable","/Image7" },
        {"SpriteLoadExitFromGameInMainMenuTable","/Image7" }

    };
    public Dictionary<string, string> GameSavePath = new Dictionary<string, string>() 
    {
        {"Save1","GameSave245847773999" },
        {"Save2","GameSave245847774999" },
        {"Save3","GameSave245847775999" }
    };
    public Dictionary<string, string> LoadMenuPaths = new Dictionary<string, string>()
    {
        {"UsuallyBackMenuPath","/MainMenu" },
        {"BackMenuPath","/SaveWhetherChange" },
        {"SaveWhetherChangeMenuPath","/MainMenu" },
        {"SoundsSettingsMenuPath","/SoundsSettingsMenu" },
        {"InputSettingsMenuPath","/InputSettingsMenu" },
        {"GraphicSettingsMenuPath","/GraphicSettingsMenu" },
        {"SettingsMenuPath","/SettingsMenu" },
        {"LoadMenuPath","/LoadMenu" },
        {"LoadPauseMenuPath","/LoadPauseMenu" },
        {"LoadPauseLoadMenuPath","/PauseLoadMenu" },
        {"LoadPauseSaveMenuPath","/PauseSaveMenu" },
        {"GameSettingsMenuPath","/GameSettingsMenu" },
        {"CreateNewGameSaveInfoButtonPath","/ChoseOfDifficultMenu" },
        {"LoadExitFromGameInMainMenuPath","/WhetherSaveInformationAndExitFromGame" },
    };


    public string LatestLoadedSave = "GameSave245847775999";

    public bool IsLoadPlayerSave = false;
}
