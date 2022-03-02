using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EfStudentRepository : GenericRepository<Student>, IStudentDal
    {
 

        // ********* Student ID Check ***
        public int CheckedID(string p)
        {
            using var c = new Context();
            var studentid = c.Students.Where(x => x.Mail == p).Select(y => y.ID).FirstOrDefault();
            return studentid;


        }
        //*** The code that checks whether the student has been registered in the system before **//
        public Student CheckStudent(string mail)
        {
            using var c = new Context();
            var checkvalue = c.Students.Where(x => x.Mail == mail).FirstOrDefault();
            return checkvalue;
        }
        //*** Get Student list by university , faculty and section
        public List<Student> GetListStudentDetails()
        {
            using (var c = new Context())
            {
                return c.Students.Include(x => x.University).Include(y => y.Section).Include(e => e.Faculty).ToList();
            }
        }

        //************** Student Filters ***********************//
        public IEnumerable<Student> GetStudentFilters(string Gender = null, string University = null, string Faculty = null, string Section = null, string MarriageStatus = null, string DeathStatus = null, string WorkStatus = null, string PhysicalDisablty = null)
        {
            using var c = new Context();
            IQueryable<Student> query = c.Students;

            if (Gender != null)
            {
                query = query.Where(i => i.Gender.ToLower().Contains(Gender.ToLower()));
            }
            if (University != null)
            {
                query = query.Where(i => i.UniversityID == Convert.ToInt16(University));

            }
            if (Faculty != null)
            {
                query = query.Where(i => i.FacultyID == Convert.ToInt16(Faculty));

            }
            if (Section != null)
            {
                query = query.Where(i => i.SectionID == Convert.ToInt16(Section));
            }
            if (MarriageStatus != null)
            {
                query = query.Where(i => i.FamilyMaritalStatus.ToLower().Contains(MarriageStatus.ToLower()));
            }
            if (DeathStatus != null)
            {
                query = query.Where(i => i.FamilyDeathStatus.ToLower().Contains(DeathStatus.ToLower()));
            }
            if (WorkStatus != null)
            {
                query = query.Where(i => i.FamilyWorkStatus.ToLower().Contains(WorkStatus.ToLower()));
            }
            if (PhysicalDisablty != null)
            {
                query = query.Where(i => i.PhyscialDisability.ToLower().Contains(PhysicalDisablty.ToLower()));
            }
            return query.Include(x => x.University).Include(i => i.Faculty).Where(x => x.Active == true).Include(i => i.Section).ToList();


        }
    }
}
