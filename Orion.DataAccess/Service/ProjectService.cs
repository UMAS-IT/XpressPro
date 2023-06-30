using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class ProjectService
    {
        public IList<Project> GetProjectByUserId(User user)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                //User dbUser = context.Users.First(x => x.Id == user.Id);

                if (user.Permission.IsAdmin)
                    return context.Projects.Include(x => x.User).OrderByDescending(x => x.Id).ToList();
                else
                    return context.Projects.Include(x => x.User).Where(x => x.UserId == user.Id).OrderByDescending(x => x.Id).ToList();

            }
        }

        public async Task<Project> CreateProject(int userId, Project project)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                User user = context.Users.FirstOrDefault(u => u.Id == project.User.Id);

                int projectNumber = GV.RandomProjectNumber();

                while (context.Projects.Any(x => x.Number == projectNumber))
                {
                    projectNumber = GV.RandomProjectNumber();
                }
                project.Number = projectNumber;

                project.CreationDate = GV.GetPacificStandardTime();

                user.Projects.Add(project);

                context.Projects.Update(project);

                await context.SaveChangesAsync();

                return project;
            }
        }

        public async Task<Project> UpdateProject(Project projectSelected)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Project currentProject = await context.Projects.Include(x => x.User).FirstOrDefaultAsync(p => p.Id == projectSelected.Id);
                User user = context.Users.FirstOrDefault(u => u.Id == projectSelected.User.Id);

                currentProject.User = user;
                currentProject.Number = projectSelected.Number;
                currentProject.Name = projectSelected.Name;
                currentProject.Notes = projectSelected.Notes;
                currentProject.Contractor = projectSelected.Contractor;
                currentProject.Engineer = projectSelected.Engineer;
                currentProject.Contact = projectSelected.Contact;
                currentProject.Location = projectSelected.Location;
                currentProject.ProposalNumber = projectSelected.ProposalNumber;
                currentProject.PlansDate = projectSelected.PlansDate;
                currentProject.Addendum = projectSelected.Addendum;

                context.Projects.Update(currentProject);
                context.SaveChanges();
                return currentProject;
            }
        }

        public async Task<bool> ProjectNumberExist(Project project)
        {
            using (GlobalDbContext contex = new GlobalDbContext())
            {
                return await contex.Projects.AnyAsync(p => p.Number == project.Number && p.Id != project.Id);
            }
        }
       
        public Project GetProjectById(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Projects.Include(x => x.User).FirstOrDefault(p => p.Id == projectId);
            }
        }

        public async Task DeleteProject(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                Project project = context.Projects.FirstOrDefault(x => x.Id == projectId);
                context.Remove(project);
                await context.SaveChangesAsync();
            }
        }

        //public Project GetProjectData(int projectId)
        //{
        //    using (GlobalDbContext context = new GlobalDbContext())
        //    {
        //        return context.Projects.AsNoTracking()
        //            .Include(p => p.User)
        //            .Include(x => x.Quotes).ThenInclude(x => x.ItemAirCooledChiller).ThenInclude(x => x.ItemAirCooledChillerCatalogAirCooledChillers).ThenInclude(x => x.Catalog)
        //            .Include(x => x.Quotes).ThenInclude(x => x.ItemPump).ThenInclude(x => x.ItemPumpCatalogPumps).ThenInclude(x => x.CatalogPump)
        //            .Include(x => x.Quotes).ThenInclude(x => x.ItemUnit).ThenInclude(x => x.ItemUnitCatalogUnits).ThenInclude(x => x.CatalogUnit)
        //            .Include(x => x.Quotes).ThenInclude(x => x.ItemVfd).ThenInclude(x => x.ItemVfdCatalogVfds).ThenInclude(x => x.CatalogVfd)
        //            .FirstOrDefault(x => x.Id == projectId);
        //    }
        //}
    }
}
