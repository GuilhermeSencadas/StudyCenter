using Logistics.Domain.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Logistics.Infrastructure.Shared;
using Logistics.Infrastructure;

namespace Logistics.Repository
{
    public class SubjectRepository : BaseRepository<Subject, SubjectIdDb>, ISubjectRepository
    {

        private readonly LogisticsDbContext _context;

        public SubjectRepository(LogisticsDbContext context) : base(context.Subjects)
        {
            this._context = context;
        }

        public async Task<Subject> GetBySubjectCode(string code)
        {
            return await this._context.Subjects
            .Where(x => code.Equals(x.Code.Code)).FirstOrDefaultAsync();
        }

        public bool ExistsSubject(string code)
        {
            Subject Subject = GetBySubjectCode(code).Result;
            return !(Subject == null);
        }

        public async Task<List<Subject>> ListSubjectsAsync(string IdSubject, string designacao)
        {
            throw new NotImplementedException();
        }
    }
}