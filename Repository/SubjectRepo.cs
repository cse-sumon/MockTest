using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly MockTestContext _context;
        private readonly DbSet<SubjectModel> _entity;
        public SubjectRepo(MockTestContext context)
        {
            _context = context;
            _entity = _context.Set<SubjectModel>();
        }

        public IEnumerable<SubjectViewModel> GetAll()
        {
          return (from s in _context.Subjects
                    select new SubjectViewModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Description = s.Description, 
                    }).AsEnumerable().ToList();
        }

        public SubjectViewModel Get(int id)
        {
            return (from s in _context.Subjects
                    where s.Id == id
                    select new SubjectViewModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Description = s.Description
                    }).AsNoTracking().SingleOrDefault();
        }


        public void Insert(SubjectViewModel model)
        {
            SubjectModel subject = new SubjectModel
            {
                Name = model.Name,
                Description = model.Description
            };
            _entity.Add(subject);
            _context.SaveChanges();
        }

        public void Update(SubjectViewModel model)
        {
            SubjectModel subject = new SubjectModel
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            _entity.Update(subject);
            _context.SaveChanges();
        }

        public void Delete(SubjectViewModel model)
        {
            SubjectModel subject = new SubjectModel
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            _entity.Remove(subject);
            _context.SaveChanges();
        }
    }
}
