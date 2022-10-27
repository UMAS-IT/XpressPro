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
        public ObservableCollection<Project> GetProjectByUserId(int userId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                User user = context.Users.First(x => x.Id == userId);

                List<Project> projects = context.Projects.Include(x => x.User).ToList();

                return projects.ToObservableCollection();
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

        public Project GetProjectData(int projectId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Projects.AsNoTracking()
                    .Include(p => p.User)
                    .Include(x => x.Units).ThenInclude(x => x.UnitItemAirCooledChillers).ThenInclude(x => x.ItemAirCooledChiller)
                    .Include(x => x.Units).ThenInclude(x => x.UnitItemPumps).ThenInclude(x => x.ItemPump)
                    .FirstOrDefault(x => x.Id == projectId);
            }
        }
    }
}
