using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebApi.Data;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Controllers
{
      [ApiController]
      [Route("[controller]")]

      public class AlunoController : ControllerBase
      {
            private readonly IRepository _repo;

            public AlunoController(IRepository repo)
            {
                  _repo = repo;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                  try
                  {
                        var result = await _repo.GetAllAlunosAsync(false);

                        return Ok(result);
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
            }

            [HttpGet("{AlunoId}")]
            public async Task<IActionResult> GetAlunoById(int AlunoId)
            {
                  try
                  {
                        var result = await _repo.GetAlunoAsyncById(AlunoId, false);

                        return Ok(result);

                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
            }

            [HttpGet("ByDisciplina/{disciplinaId}")]
            public async Task<IActionResult> GetByDisciplinaId(int disciplinaId)
            {
                  try
                  {
                        var result = await _repo.GetAlunosAsyncByDisciplinaId(disciplinaId, false);

                        return Ok(result);
                  }
                  catch (Exception ex)
                  {
                        return BadRequest($"Error: {ex.Message}");
                  }
            }

            [HttpPost]
            public async Task<IActionResult> Post(Aluno model)
            {
                  try
                  {
                        _repo.Add(model);
                        if (await _repo.SaveChangesAsync())
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

            [HttpPut("{AlunoId}")]
            public async Task<IActionResult> Put(int alunoId, Aluno model)
            {
                  try
                  {
                        var aluno = await _repo.GetAlunoAsyncById(alunoId, false);
                        if(aluno == null) return NotFound("Aluno não encontrado");

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

            [HttpDelete("{alunoId}")]
            public async Task<IActionResult> Delete(int alunoId)
            {
                  try
                  {
                        var aluno = await _repo.GetAlunoAsyncById(alunoId, false);
                        if(aluno == null) return NotFound();

                        _repo.Delete(aluno);

                        if(await _repo.SaveChangesAsync())
                        {
                              return Ok(new {message = "Deletado"});
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