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
    public class SubjectRepository : BaseRepository<Subject, SubjectCodeDb>, ISubjectRepository
    {

        private readonly LogisticsDbContext _context;


        public SubjectRepository(LogisticsDbContext context) : base(context.Subjects)
        {
            this._context = context;
        }
        public async Task<Subject> GetBySubjectCode(string Id)
        {
            return await this._context.Subjects
            .Where(x => Id.Equals(x.Code.code)).FirstOrDefaultAsync();
        }

        public bool ExistsSubject(string Id){
            Subject Subject = GetBySubjectCode(Id).Result;
            return !(Subject == null);
        }

        public async Task<List<Subject>> ListSubjectsAsync(string IdSubject, string designacao){
            throw new NotImplementedException();
        }
    }
}