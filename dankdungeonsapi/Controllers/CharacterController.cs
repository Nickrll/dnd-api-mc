using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dankdungeonsapi.Models;
using dankdungeonsapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dankdungeonsapi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _service;

        public CharacterController(ICharacterService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<CharacterModel> PutCharacter(CharacterModel chara)
        {
            CharacterModel character = (CharacterModel)_service.PostCharacter(chara);
            if (character == null)
                return NotFound();
            else
            return character;
        }
    }
}