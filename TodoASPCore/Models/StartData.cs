using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace TodoASPCore.Models
{
    public static class StartData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<TaskContext>();

            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(
                    new Task
                    {
                        Name = "Eat",
                        Date = DateTime.Now,
                        Status = false
                    },
                    new Task
                    {
                        Name = "Sleep",
                        Date = DateTime.Now,
                        Status = false
                    }

                );
                context.SaveChanges();

            }

        }
    }
}
