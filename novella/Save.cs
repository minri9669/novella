using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Solution.StoryManager
{
    public class Save
    {
        public string SceneId { get; set; } = "";
        public int DialogueIndex { get; set; }
        public string PlayerName { get; set; } = "";
        public Dictionary<string, bool> StoryFlags { get; set; } = new();
        public Dictionary<string, Dictionary<string, int>> CharacterStats { get; set; } = new();
        public List<string> ChoicesMade { get; set; } = new();
        public DateTime SaveTime { get; set; }
    }
    public class SaveSystem
    {
        private static readonly string SaveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");
        private Save _currentGame = new();

        public SaveSystem()
        {
            if (!Directory.Exists(SaveDirectory))
            {
                Directory.CreateDirectory(SaveDirectory);
            }
        }
        public void SaveGame(int saveSlot = 1)
        {
            _currentGame.SaveTime = DateTime.Now;

            string filePath = Path.Combine(SaveDirectory, $"save_{saveSlot}.json");
            string json = JsonSerializer.Serialize(_currentGame, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
            Console.WriteLine($"Игра сохранена в слот {saveSlot}: {filePath}");
        }
        public bool LoadGame(int saveSlot = 1)
        {
            string filePath = Path.Combine(SaveDirectory, $"save_{saveSlot}.json");

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Сохранение в слоте {saveSlot} не найдено!");
                return false;
            }

            string json = File.ReadAllText(filePath);
            _currentGame = JsonSerializer.Deserialize<Save>(json) ?? new Save();

            Console.WriteLine($"Игра загружена из слота {saveSlot}!");
            Console.WriteLine($"Сцена: {_currentGame.SceneId}, Диалог: {_currentGame.DialogueIndex}");
            return true;
        }
        public bool DeleteSave(int saveSlot = 1)
        {
            string filePath = Path.Combine(SaveDirectory, $"save_{saveSlot}.json");

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Сохранение в слоте {saveSlot} не найдено!");
                return false;
            }

            File.Delete(filePath);
            Console.WriteLine($"Сохранение в слоте {saveSlot} удалено!");
            return true;
        }
        public List<int> GetSaves()
        {
            List<int> saveSlots = new();

            if (!Directory.Exists(SaveDirectory))
            {
                return saveSlots;
            }

            string[] files = Directory.GetFiles(SaveDirectory, "save_*.json");

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (int.TryParse(fileName.Replace("save_", "").Replace(".json", ""), out int slot))
                {
                    saveSlots.Add(slot);
                }
            }

            saveSlots.Sort();
            return saveSlots;
        }
        public Save CurrentGame => _currentGame;

        public void SetScene(string sceneId)
        {
            _currentGame.SceneId = sceneId;
        }

        public void SetDialogueIndex(int index)
        {
            _currentGame.DialogueIndex = index;
        }

        public void SetPlayerName(string name)
        {
            _currentGame.PlayerName = name;
        }

        public void SetStoryFlag(string flagName, bool value)
        {
            _currentGame.StoryFlags[flagName] = value;
        }

        public bool GetStoryFlag(string flagName)
        {
            return _currentGame.StoryFlags.GetValueOrDefault(flagName, false);
        }
        public void SetCharacterStat(string charName, string statName, int value)
        {
            if (!_currentGame.CharacterStats.ContainsKey(charName))
            {
                _currentGame.CharacterStats[charName] = new();
            }
            _currentGame.CharacterStats[charName][statName] = value;
        }

        public int GetCharacterStat(string charName, string statName)
        {
            if (_currentGame.CharacterStats.TryGetValue(charName, out var stats) && stats.TryGetValue(statName, out var value))
            {
                return value;
            }
            return 0;
        }

        public void AddChoice(string choice)
        {
            _currentGame.ChoicesMade.Add(choice);
        }

        public List<string> GetChoicesMade()
        {
            return new List<string>(_currentGame.ChoicesMade);
        }

        public void NewGame()
        {
            _currentGame = new Save();
        }
    }
}
