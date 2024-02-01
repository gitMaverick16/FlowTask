using FlowTask.Models;
using FlowTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _cardService.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Card card)
        {
            return Ok(await _cardService.Add(card));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Card card)
        {
            var cardSearched = await _cardService.Get(card.Id.ToString());
            if (cardSearched is null)
            {
                return NotFound();
            }
            return Ok(await _cardService.Update(card));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var card = await _cardService.Get(id);
            if (card is null)
            {
                return NotFound();
            }
            return Ok(await _cardService.Delete(card));
        }
    }
}
