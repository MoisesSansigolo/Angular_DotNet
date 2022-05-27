using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebApi.Data;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Controllers
{
      [ApiController]
      [Route("[controller]")]

      public class ProfessorController : ControllerBase
      {
            private readonly IRepository _repo;

            public ProfessorController(IRepository repo)
            {
                  _repo = repo;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                  try
                  {
                        var result = await _repo.GetAllProfessoresAsync(true);
                        return Ok(result);
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
            }

            [HttpGet("{ProfessorId}")]
            public async Task<IActionResult> GetByProfessorId(int ProfessorId)
            {
                  try
                  {
                        var result = await _repo.GetProfessorAsyncById(ProfessorId, true);
                        return Ok(result);
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
            }

            [HttpGet("ByAluno/{alunoId}")]
            public async Task<IActionResult> GetByAlunoId(int alunoId)
            {
                  try
                  {
                        var result = await _repo.GetProfessoresAsyncByAlunoId(alunoId, false);
                        return Ok(result);
                  }
                  catch (Exception ex)
                  {
                         return BadRequest($"Error: {ex.Message}");
                  }

            }

            [HttpPost]
            public async Task<IActionResult> Post(Professor model)
            {
                  try
                  {
                        _repo.Add(model);
                        if(await _repo.SaveChangesAsync())
                        {
                              return Ok(model);
                        }
                        
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
                  return BadRequest();
            }

            [HttpPut("{ProfessorId}")]
            public async Task<IActionResult> Put(int professorId, Professor model) 
            {
                  try
                  {
                        var professor = await _repo.GetProfessorAsyncById(professorId, false);
                        if(professor == null) return NotFound("Professor não encontrado");

                        _repo.Update(model);

                        if(await _repo.SaveChangesAsync())
                        {
                              return Ok(model);
                        }
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
                  return BadRequest();
                  
            }

            [HttpDelete("{professorId}")]
            public async Task<IActionResult> Delete(int professorId)
            {
                  try
                  {                        
                  
                        var professor = await _repo.GetProfessorAsyncById(professorId, false);
                        if(professor == null) return NotFound("Professor não encontrado");

                        _repo.Delete(professor);

                        if(await _repo.SaveChangesAsync())
                        {
                              return Ok("Professor deletado com sucesso");
                        }
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
                  return BadRequest();
            }

            
      }

}