using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Repository.Interface
{
    public interface ISubjectRepo
    {
        IEnumerable<SubjectViewModel> GetAll();
        SubjectViewModel Get(int id);
        void Insert (SubjectViewModel model);
        void Update (SubjectViewModel model);
        void Delete (SubjectViewModel model);
    }
}
