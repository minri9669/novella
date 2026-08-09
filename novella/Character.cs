using System;
using System.Collections.Generic;

namespace Solution.CharacterManager
{
    public class Character
    {
        public string Id { get; set; }
        public string Name { get; set; } = "";
        public Dictionary<string, int> Stats { get; set; } = new();
        public bool IsAlive { get; set; } = true;

        public Character(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class CharacterManager
    {
        private readonly Dictionary<string, Character> _characters = new();

        public void AddCharacter(string id, string name)
        {
            if (_characters.ContainsKey(id))
                throw new ArgumentException($"Персонаж с id \"{id}\" уже существует.");

            _characters[id] = new Character(id, name);
        }

        public Character? GetCharacter(string id)
        {
            return _characters.TryGetValue(id, out var character) ? character : null;
        }

        public void UpdateCharacter(string id, string? name = null, Dictionary<string, int>? newStats = null)
        {
            var character = GetCharacter(id);
            if (character == null)
                throw new ArgumentException($"Персонаж с id \"{id}\" не найден.");

            if (name != null)
                character.Name = name;

            if (newStats != null)
            {
                foreach (var stat in newStats)
                    character.Stats[stat.Key] = stat.Value;
            }
        }

        public void KillCharacter(string id)
        {
            var character = GetCharacter(id);
            if (character == null)
                throw new ArgumentException($"Персонаж с id \"{id}\" не найден.");

            character.IsAlive = false;
        }

        public List<Character> GetAllCharacters()
        {
            return new List<Character>(_characters.Values);
        }
    }

}