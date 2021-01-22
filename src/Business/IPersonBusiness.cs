using curso_RestApi1.src.Model;
using System.Collections.Generic;

namespace curso_RestApi1.src.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
