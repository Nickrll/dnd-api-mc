using dankdungeonsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dankdungeonsapi.Services
{
    public interface ICharacterService
    {
        object PostCharacter(CharacterModel chara);
        object SetCharacter(int charid, int userid);
        object GetCharacter(int charid, int userid);
        object GetCharacters(int userid);
        object DeleteCharacter(int charid, int userid);
    }
}
