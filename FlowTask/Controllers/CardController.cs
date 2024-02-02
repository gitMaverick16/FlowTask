using FlowTask.DTOs;
using FlowTask.Services;
using FlowTask.Validators;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Post([FromBody] CreateCardDTO card)
        {
            var validator = new CreateCardValidator();
            var validateResult = validator.Validate(card);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
            return Ok(await _cardService.Add(card));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateCardDTO card)
        {
            var validator = new UpdateCardValidator();
            var validateResult = validator.Validate(card);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
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
