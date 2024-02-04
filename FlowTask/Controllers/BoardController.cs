using FlowTask.DTOs;
using FlowTask.Models;
using FlowTask.Services;
using FlowTask.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FlowTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _boardService;
        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _boardService.Get(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _boardService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBoardDTO board)
        {
            var validator = new CreateBoardValidator();
            var validateResult = validator.Validate(board);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
            return Ok(await _boardService.Add(board));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateBoardDTO board)
        {
            var validator = new UpdateBoardValidator();
            var validateResult = validator.Validate(board);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
            var boardSearched = await _boardService.Get(board.Id.ToString());
            if (boardSearched is null)
            {
                return NotFound();
            }
            return Ok(await _boardService.Update(board));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var board = await _boardService.Get(id);
            if(board is null)
            {
                return NotFound();
            }
            return Ok(await _boardService.Delete(board));
        }
    }
}
