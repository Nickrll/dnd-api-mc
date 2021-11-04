using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dankdungeonsapi.Models;

namespace dankdungeonsapi.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly Dictionary<string, CharacterModel> _character;

        public CharacterService()
        {
            _character = new Dictionary<string, CharacterModel>();
        }

        public object DeleteCharacter(int charid, int userid)
        {
            throw new NotImplementedException();
        }

        public object GetCharacter(int charid, int userid)
        {
            throw new NotImplementedException();
        }

        public object GetCharacters(int userid)
        {
            throw new NotImplementedException();
        }

        public object PostCharacter(CharacterModel chara)
        {
            throw new NotImplementedException();
        }

        public object PutCharacter(CharacterModel chara)
        {
            _character.Add(chara.Name, chara);
            return chara;
        }

        public object SetCharacter(int charid, int userid)
        {
            throw new NotImplementedException();
        }
    }
}
