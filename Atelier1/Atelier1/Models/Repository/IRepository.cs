﻿namespace Atelier1.Models.Repository
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        List<T> Search(String term);
        T FindByID(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);

        double SalaryAverage();
        double MaxSalary();
        int HrEmployeesCount();
    }
}
