using Demo.BLL.Models;
using Demo.DAL.DataBase;
using Demo.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Service
{
    public class DepartmentService :IDepartmentService
    {
        ApplicationContext db =new ApplicationContext();

        public async Task CreateAsync(DepartmentDTO departmentDTO)
        {
            Department department = new Department();
            {
                department.Id = departmentDTO.Id;
                department.Name = departmentDTO.Name;
                department.Code = departmentDTO.Code;
            } 
            await db.Departments.AddAsync(department);
            await db.SaveChangesAsync();
        }



        public async Task<List<DepartmentDTO>> GetAsync(Expression<Func<DepartmentDTO, bool>> filter)
        {
            var result = await db.Departments.Select(a => new DepartmentDTO()
            {
                Id = a.Id,
               Name = a.Name,
               Code = a.Code

        }).Where(filter).ToListAsync();
          
            return  result;
        }
        public async Task<DepartmentDTO> GetByIdAsync(Expression<Func<DepartmentDTO, bool>> filter)
        {
            var result = await db.Departments.Select(a => new DepartmentDTO()
            {
                Id = a.Id,
                Name = a.Name,
                Code = a.Code

            }).Where(filter).FirstOrDefaultAsync();

            return result;
        }
        public async Task UpdateAsync(DepartmentDTO departmentDTO)
        {
            var oldData = await db.Departments.FindAsync(departmentDTO.Id);
            oldData.Name = departmentDTO.Name;
            oldData.Code = departmentDTO.Code;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(DepartmentDTO departmentDTO)
        {
            Department department = new Department();
            {
                department.Id = departmentDTO.Id;
                department.Name = departmentDTO.Name;
                department.Code = departmentDTO.Code;
            }
            db.Departments.Remove(department);
            await db.SaveChangesAsync();

        }


    }

    public interface IDepartmentService
    {
        Task<List<DepartmentDTO>> GetAsync(Expression<Func<DepartmentDTO, bool>> filter);
        Task CreateAsync(DepartmentDTO departmentDTO);
        Task<DepartmentDTO> GetByIdAsync(Expression<Func<DepartmentDTO, bool>> filter);
        //Task<DepartmentDTO> EditAsync(Expression<Func<DepartmentDTO, bool>> filter);
        Task UpdateAsync(DepartmentDTO departmentDTO);
        Task DeleteAsync(DepartmentDTO departmentDTO);


    }
}
