using System.Threading.Tasks;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Data
{
    public interface IRepository
    {
        //Geral
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //Aluno
         Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor);
         Task<Aluno[]> GetAlunosAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina);
         Task<Aluno> GetAlunoAsyncById(int alunoId, bool includeProfessor);

         //Professor
         Task<Professor[]> GetAllProfessoresAsync(bool inculdeAluno);
         Task<Professor> GetProfessorAsyncById(int professorId, bool inculdeAluno);
         Task<Professor[]> GetProfessoresAsyncByAlunoId(int alunoId, bool includeDisciplina);
    }
}