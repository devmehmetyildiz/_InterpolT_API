using Microsoft.EntityFrameworkCore;
using StarNoteWebAPICore.DataAccess.Repositories.Abstract;
using StarNoteWebAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNoteWebAPICore.DataAccess.Repositories.Concrete
{
    public class ReportsettingsRepository : Repository<ReportsettingModel>, IReportsettingsRepository
    {
        public StarNoteEntity starnoteapicontext { get { return _context as StarNoteEntity; } }

        private DbSet<ReportsettingModel> _dbSet;
        public ReportsettingsRepository(StarNoteEntity context) : base(context)
        {
            _dbSet = starnoteapicontext.Set<ReportsettingModel>();
        }
    }
}
